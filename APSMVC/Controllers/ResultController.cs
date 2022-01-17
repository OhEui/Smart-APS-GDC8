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
        public async Task<ActionResult> EQPGantt(string[] EQP_GROUP=null, string[] EQP_ID=null, string[] PRODUCT_ID=null,
            DateTime? Start_Date = null, DateTime? End_Date = null)
        {

            var access_token = Request.Headers["authorization"];
            ServiceHelp srv = new ServiceHelp(true, access_token);
            ChartCommonData commonData = await srv.GetListAsync<ChartCommonData>($"api/Result/EQPGantt/Common", null); // 설비그룹, 설비ID, 제품ID 가져오기


            List<ComboItemVO> comboItem = commonData.ComboItemList;

            string result = await srv.PostJsonStringAsync($"api/Result/EQPGantt/Data", new ReqEQPGantt() 
            {
                EQP_GROUP = EQP_GROUP,
                EQP_ID = EQP_ID,
                PRODUCT_ID = PRODUCT_ID,
                Start_Date = Start_Date ?? commonData.Start_Date,
                End_Date = End_Date ?? commonData.End_Date
            });  // 차트 데이터 가져오기

            if (result == null)
            {
                return Redirect("/user/login");
            }

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
            List<string> qParameters = new List<string>();
            if (EQP_GROUP!=null)
                qParameters.AddRange(EQP_GROUP);
            if (EQP_ID != null)
                qParameters.AddRange(EQP_ID);
            if (PRODUCT_ID != null)
                qParameters.AddRange(PRODUCT_ID);

            EQPGanttModel model = new EQPGanttModel
            {
                EqpIDList = new SelectList(eqpIDList, "Code", "CodeName"),
                EqpGroupList = new SelectList(eqpGroupList, "Code", "CodeName"),
                ProductIDList = new SelectList(productIDList, "Code", "CodeName"),
                CategoryList = categoryList,

                ChartDataJson = result,
                DropDownAttributes = new Dictionary<string, object>() {
                    { "class", "condition" }, { "style", "width:100%;" },
                    { "multiple", "multiple" }, { "data-close-on-select", "false" }
                },
                QueryParameters = qParameters?.ToArray(),

                Start_Date = Start_Date ?? commonData.Start_Date,
                End_Date = End_Date ?? commonData.End_Date,
                Min_Date = commonData.Start_Date,
                Max_Date = commonData.End_Date
            };
            return View(model);
        }


        public async Task<ActionResult> Utilization(string MACHINE_STATE = "BUSY", string VERSION_NO = null)
        {
            ServiceHelp srv = new ServiceHelp(true);

            ChartCommonData commonData = await srv.GetListAsync<ChartCommonData>($"api/Result/Utilization/Common", null); // 설비그룹, 설비ID, 제품ID 가져오기
            List<ComboItemVO> comboItem = commonData.ComboItemList;

            var result = 
                await srv.PostAsyncList<ReqUtilizationData, ResUtilizationData> ($"api/Result/Utilization/Data", new ReqUtilizationData()
            {
                MachineState = MACHINE_STATE,
                VersionNo = VERSION_NO
            });  // 차트 데이터 가져오기

            var chartData = result;
            var mslist = comboItem.Where((i) => i.Category == "MACHINE_STATE").ToList();
            var vnlist = comboItem.Where((i) => i.Category == "VERSION_NO").ToList();

            // 차트 데이터 그룹화 (EQP_GROUP)
            var dictionary = 
                chartData.GroupBy((i) => i.EQP_GROUP).ToDictionary(g => g.Key, g => g.ToList());

            // table 생성용 데이터
            // result에서 target_date 데이터만 추출 => table의 header로 사용
            List<List<string>> tableData = new List<List<string>>();
            
            List<string> headerRow = new List<string>();
            headerRow.Add("설비그룹");
            headerRow.AddRange(result.Select((i) => i.TARGET_DATE.ToString("yyyyMMdd")).ToHashSet());
            tableData.Add(headerRow);

            foreach (var item in dictionary)
            {
                List<string> row = new List<string>();
                row.Add(item.Key);
                row.AddRange(item.Value.Select((i) => $"{i.RATE:#0.#0}%"));
                tableData.Add(row);
            }

            UtilizationModel model = new UtilizationModel() {
                ChartDictionary = dictionary,
                CurrentMachineState = MACHINE_STATE,
                MachineStateList = new SelectList(mslist, "Code", "CodeName", "BUSY"),
                VersionNoList = new SelectList(vnlist, "Code", "CodeName"),
                DropDownAttributes = new Dictionary<string, object>() {
                    { "class", "condition" }, { "style", "width:100%;" }
                },

                TableData = tableData
            };

            return View(model);
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