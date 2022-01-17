
using APSServer.Models;

using APSVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APSServer.Controllers
{
    [RoutePrefix("api/Result")]
    public partial class ResultController : ApiController
    {
        // https://localhost:44309/api/Result/EQPGantt
        [HttpPost]
        [Route("EQPGantt/Data")][Authorize]
        public IHttpActionResult GetEQPGanttChartData(ReqEQPGantt req)
        {
            // 차트 데이터 가져오기
            using (ResultDAC dac = new ResultDAC())
            {
                var data = dac.GetEQPGanttData(req);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpGet]
        [Route("EQPGantt/Common")]
        public IHttpActionResult GetEQPGanttCommonData()
        {
            // 설비그룹, 설비ID, 제품ID 가져오기
            using (ResultDAC dac = new ResultDAC())
            {
                var data = dac.GetEQPGanttCommonData();

                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
        }

        //GET : https://localhost:44309/api/Result/getLOTList
        [HttpGet]
        [Route("getLOTList")]
        public List<ChartData> getLOTList(string productID, string lotID)
        {
            LOTDAC db = new LOTDAC();
            return db.GetLOTList(productID, lotID);
        }


        //GET : https://localhost:44309/api/Result/getLOTCategory
        [HttpGet]
        [Route("getLOTCategory")]
        public List<LOTGanttCategory> getLOTCategory(string productID, string lotID)
        {
            LOTDAC db = new LOTDAC();
            return db.getLOTCategory(productID, lotID);
        }

        //GET : https://localhost:44309/api/Result/getComboList
        [HttpGet]
        [Route("getComboList")]
        public List<ComboItemVO> getComboList()
        {
            LOTDAC db = new LOTDAC();
            return db.getComboList();
        }
    }
}
