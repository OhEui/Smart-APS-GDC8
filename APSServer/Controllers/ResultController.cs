
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
        [HttpGet]
        [Route("EQPGantt")][Authorize]
        public IHttpActionResult GetEQPGanttData()
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
    }
}
