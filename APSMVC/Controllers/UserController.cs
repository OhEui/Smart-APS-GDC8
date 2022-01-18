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

        [HttpGet]
        public async Task<ActionResult> LogOut()
        {
            var access_token = Request.Headers["authorization"];
            ServiceHelp srv = new ServiceHelp(true, access_token);
            WebMessage result = await srv.PostAsyncNone($"api/Account/Logout", new object()); // 설비그룹, 설비ID, 제품ID 가져오기

            return RedirectToAction("Login");
        }


    }
}