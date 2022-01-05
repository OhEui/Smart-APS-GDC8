using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APSMVC.Controllers
{
    /*
        EQP Gantt, 가동률 분석
        ResultController는 나중에 하나의 파일로 합칠 예정
     */
    public partial class ResultController : Controller
    {
        // GET: Result
        public ActionResult Index()
        {
            return View();
        }
    }
}