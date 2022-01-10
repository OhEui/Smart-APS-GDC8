using APSUtil.Http;
using APSVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace APSMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOut()
        {
            TokenStorage.Clear();
            return RedirectToAction("Login");
        }

        [HttpPost]
        public async Task<ActionResult> Auth(ReqUserLogin reqData) 
        {
            WebMessage<TokenModel> resToken;

            var test = Request.Headers["Referer"]; //https://localhost:44397/User/Login, 이전 경로 체크용으로 사용할 수 있음

            
            // access_token 가져오기
            using (ServiceHelp srv = new ServiceHelp(IsWebClient:true))
            {
                resToken = await srv.PostAsync<ReqUserLogin, TokenModel>("api/Account/Login", reqData);
                if (resToken != null && resToken.IsSuccess)
                {
                    TokenStorage.AccessToken = resToken.Data.AccessToken;
                }
                else
                {
                    string msg = resToken?.ResultMessage ?? "로그인 중 문제가 발생하였습니다.";
                    return Content($@"<script language='javascript' type='text/javascript'> 
alert('{msg}'); 
history.back();
</script>");
                }
            }

            return Redirect("/Result/Utilization");
        }
    }
}