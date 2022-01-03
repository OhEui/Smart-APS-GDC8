using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Filters;
using APSEncrypt;
using APSServer.Models;
using APSServer.Principal;
using APSServer.Results;

namespace APSServer.Authentication.Filters
{
    public class BearerAuthenticationAttribute : Attribute, IAuthenticationFilter
    {
        public bool AllowMultiple => false;

        public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
        {
            HttpRequestMessage request = context.Request;
            AuthenticationHeaderValue authorization = request.Headers.Authorization;
            
            if (authorization == null)
            {
                // No authentication was attempted (for this authentication method).
                // Do not set either Principal (which would indicate success) or ErrorResult (indicating an error).
                return;
            }
            if (authorization.Scheme != "Bearer")
            {
                // No authentication was attempted (for this authentication method).
                // Do not set either Principal (which would indicate success) or ErrorResult (indicating an error).
                return;
            }
            if (string.IsNullOrEmpty(authorization.Parameter))
            {
                // Authentication was attempted but failed. Set ErrorResult to indicate an error.
                context.ErrorResult = new AuthenticationFailureResult("Missing credentials", request);
                return;
            }
            
            // 헤더 분석
            
            // 인증작업 실시
            IPrincipal principal = await AuthenticateAsync("userName", "password");

            if (principal == null)
            {
                // Authentication was attempted but failed. Set ErrorResult to indicate an error.
                context.ErrorResult = new AuthenticationFailureResult("Invalid username or password", request);
            }
            else
            {
                // Authentication was attempted and succeeded. Set Principal to the authenticated user.
                context.Principal = principal;
                Logger.APILogger(principal, request); // API 실행 전 로그에 기록
            }
        }

        protected async Task<IPrincipal> AuthenticateAsync(string userName, string password) 
        {
            using (UserDAC dac = new UserDAC())
            {
                var data = dac.Login(userName, password);
                if (data == null)
                {
                    return null;
                }
                if (!SHA256.VerifyPassword(password, data.User_PWD, data.Salt))
                {
                    return null;
                }

                var principal = await Task.Run(() => new UserPrincipal(data));
                return principal;
            }
        }

        public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
        {
            //return Task.FromResult(0); // TEST
            throw new NotImplementedException();
        }
        
    }
}