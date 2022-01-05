using APSServer.Filters;
using APSServer.Models;
using APSServer.Principal;
using APSVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APSServer.Controllers
{
    [RoutePrefix("api/Result")][UserAuthentication][Authorize]
    public class ResultController : ApiController
    {
        // https://localhost:44309/api/Result/EQPGantt
        [HttpPost]
        [Route("EQPGantt")]
        public IHttpActionResult GetEQPGanttData()
        {
            var msg = new WebMessage<List<ChartData>>();

            // APIController에서 로그인한 유저의 ID를 얻는법
            // 컨트롤러에 [UserAuthentication][Authorize]가 적용되어 있어야 함
            string userID = (RequestContext.Principal as UserPrincipal)?.User_ID ?? null;

            using (ResultDAC dac = new ResultDAC())
            {
                var data = dac.GetEQPGanttData();
                if (data != null)
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "데이터를 불러왔습니다.";
                    msg.Data = data;
                    return Ok(msg);
                }
                else
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "데이터를 불러오는 중 문제가 발생하였습니다.";
                    return Content(HttpStatusCode.NotFound, msg);
                }
            }
        }
    }
}
