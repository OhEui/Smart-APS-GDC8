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
    public partial class ResultController : ApiController
    {
        // https://localhost:44309/api/Result/EQPGantt
        [HttpPost]
        [Route("Utilization/Data")]
        public IHttpActionResult GetUtilChartData(ReqUtilizationData req)
        {
            // 차트 데이터 가져오기
            using (ResultDAC dac = new ResultDAC())
            {
                var data = dac.GetUtilChartData(req);
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
        [Route("Utilization/Common")]
        public IHttpActionResult GetUtilChartCommonData()
        {
            // 설비그룹, 설비ID, 제품ID 가져오기
            using (ResultDAC dac = new ResultDAC())
            {
                var data = dac.GetUtilChartCommonData();

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
    }
}
