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
    /*
        LOT Gantt
        ResultController는 나중에 하나의 파일로 합칠 예정
    */
    public partial class ResultController : Controller
    {
        public async Task<ActionResult> LOTGantt()
        {
            ServiceHelp srv = new ServiceHelp(true);
            //List<ChartData> list = null;

            string result = await srv.GetJsonStringAsync("api/Result/getLOTList");
            string cate = await srv.GetJsonStringAsync("api/Result/getLOTCategory");

            ViewBag.Data = result;
            ViewBag.Category = cate;
            return View();
        }
    }
}