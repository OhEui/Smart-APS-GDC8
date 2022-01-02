using APSServer.Models;
using APSServer.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace APSServer.Filters
{

    public class UserAuthenticationAttribute : BasicAuthenticationAttribute
    {
        protected override async Task<IPrincipal> AuthenticateAsync(string id, string password, 
            CancellationToken cancellationToken)
        {
            using (UserDAC dac = new UserDAC())
            {
                var data = dac.Login(id, password);
                if (data == null)
                {
                    return null;
                }

                // Create a ClaimsIdentity with all the claims for this user.
                cancellationToken.ThrowIfCancellationRequested(); // Unfortunately, IClaimsIdenityFactory doesn't support CancellationTokens.
                await Task.Delay(100);
                return new UserPrincipal(data);
            }


        }
    }
}