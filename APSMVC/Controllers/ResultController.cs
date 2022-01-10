using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using APSUtil.Http;

namespace APSMVC.Controllers
{
    /*
        EQP Gantt, 가동률 분석
        ResultController는 나중에 하나의 파일로 합칠 예정
     */
    public partial class ResultController : Controller
    {
        public async Task<ActionResult> EQPGantt()
        {
            /*
            if (false) 
            {
                string msg = "로그인이 필요합니다";
                return Content($@"<script language='javascript' type='text/javascript'> 
alert('{msg}'); 
history.back();
</script>");
            }
            */
            //var test = HttpContext.Authentication
            ServiceHelp srv = new ServiceHelp(true);
            string result = await srv.GetJsonStringAsync("api/Result/EQPGantt");

            ViewBag.Data = result;
            return View();
        }

        public ActionResult Utilization()
        {
            return View();
        }
    }
}