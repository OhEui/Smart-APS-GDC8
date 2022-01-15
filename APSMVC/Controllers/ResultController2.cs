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
        public async Task<ActionResult> LOTGantt(string productID, string lotID)
        {
            ServiceHelp srv = new ServiceHelp(true);
            List<ComboItemVO> comboItem = null;
            //List<ChartData> list = null;

            string result = await srv.GetJsonStringAsync($"api/Result/getLOTList?productID={productID}&lotID={lotID}");
            string cate = await srv.GetJsonStringAsync($"api/Result/getLOTCategory?productID={productID}&lotID={lotID}");
            comboItem = await srv.GetListAsync("api/Result/getComboList", comboItem);

            comboItem.Insert(0, new ComboItemVO { Code = "", CodeName = "전체" });

            ViewBag.Data = result;
            ViewBag.Category = cate;
            //ViewBag.Combo = new SelectList(comboItem, "Code","CodeName");
            ViewBag.Combo = comboItem;
            return View();
        }
    }
}