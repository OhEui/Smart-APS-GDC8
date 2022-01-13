
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
    public class ResultController : ApiController
    {
        // https://localhost:44309/api/Result/EQPGantt
        [HttpPost]
        [Route("EQPGantt/Data")]
        public IHttpActionResult GetEQPGanttChartData(ReqEQPGantt req)
        {
            // APIController에서 로그인한 유저의 ID를 얻는법
            // 컨트롤러에 [Authorize]가 적용되어 있어야 함

            using (ResultDAC dac = new ResultDAC())
            {
                var data = dac.GetEQPGanttData();
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    //return Content(HttpStatusCode.NotFound, msg); // WebMessage를 사용하는 경우
                    return NotFound(); // WebMessage를 사용하지 않는 경우
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
        public List<ChartData> getLOTList()
        {
            LOTDAC db = new LOTDAC();
            return db.GetLOTList();
        }


        //GET : https://localhost:44309/api/Result/getLOTCategory
        [HttpGet]
        [Route("getLOTCategory")]
        public List<LOTGanttCategory> getLOTCategory()
        {
            LOTDAC db = new LOTDAC();
            return db.getLOTCategory();
        }
    }
}
