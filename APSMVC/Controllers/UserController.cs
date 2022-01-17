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
        public ActionResult LogOut()
        {
            // Header에서 token을 제거하는 ajax 코드 실행해야함
            return RedirectToAction("Login");
        }

        
    }
}