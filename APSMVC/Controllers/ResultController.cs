using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using APSMVC.Models;
using APSUtil.Http;
using APSVO;

namespace APSMVC.Controllers
{
    /*
        EQP Gantt, 가동률 분석
        ResultController는 나중에 하나의 파일로 합칠 예정
     */
    public partial class ResultController : Controller
    {
        public async Task<ActionResult> EQPGantt(string[] EQP_GROUP=null, string[] EQP_ID=null, string[] PRODUCT_ID=null)
        {
            ServiceHelp srv = new ServiceHelp(true);

            List<ComboItemVO> comboItem = await srv.GetListAsync<List<ComboItemVO>>($"api/Result/EQPGantt/Common", null); // 설비그룹, 설비ID, 제품ID 가져오기
            string result = await srv.PostJsonStringAsync($"api/Result/EQPGantt/Data", new ReqEQPGantt() 
            {
                EQP_GROUP = EQP_GROUP,
                EQP_ID = EQP_ID,
                PRODUCT_ID = PRODUCT_ID
            });  // 차트 데이터 가져오기

            var eqpIDList= comboItem.Where((i) => i.Category == "EQP_ID").ToList();
            var eqpGroupList = comboItem.Where((i) => i.Category == "EQP_GROUP").ToList();
            var productIDList = comboItem.Where((i) => i.Category == "PRODUCT_ID").ToList();
            var categoryList = eqpIDList.Select((i) => new CategoryElement(i.Code)).ToList();

            /*
            ComboItemVO blankItem = new ComboItemVO() { Code = "", CodeName = "전체" };
            eqpIDList.Insert(0, blankItem);
            eqpGroupList.Insert(0, blankItem);
            productIDList.Insert(0, blankItem);
            */

            EQPGanttModel model = new EQPGanttModel
            {
                EqpIDList = new SelectList(eqpIDList, "Code", "CodeName"),
                EqpGroupList = new SelectList(eqpGroupList, "Code", "CodeName"),
                ProductIDList = new SelectList(productIDList, "Code", "CodeName"),
                CategoryList = categoryList,

                ChartDataJson = result,
                DropDownAttributes = new Dictionary<string, object>() {
                    { "class","condition" }, { "style", "width:100%;" }, 
                    { "multiple", "multiple" } , {"data-close-on-select" ,"false"} 
                }
            };
            return View(model);
        }


        public ActionResult Utilization()
        {
            return View();
        }
    }

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
    //var test = HttpContext.Request.Headers["Authorization"];

}