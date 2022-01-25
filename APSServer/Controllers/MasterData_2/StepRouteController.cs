using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APSVO;
using APSServer.Models;
using APSServer.Filters;

namespace APSServer.Controllers
{
    [Authorize]
    [APILogger]
    [RoutePrefix("api/step_route")]
    public class StepRouteController : ApiController
    {
        ////Post : https://localhost:44309/api/step_route/save
        [HttpPost]
        [Route("save")]
        public IHttpActionResult saveStepRoute(StepRouteVO StepRoute)
        {
            WebMessage msg = new WebMessage();
            StepDAC db = new StepDAC();
            bool result = db.saveStepRouteList(StepRoute);

            if (result)
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "성공적으로 등록되었습니다.";
            }
            else
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "저장 중 오류가 발생했습니다.";
            }
            return Ok(msg);
        }
        //GET : https://localhost:44309/api/step_route
        [HttpGet]
        [Route]
        public List<StepRouteVO> getStepRouteList()
        {
            StepDAC db = new StepDAC();
            return db.getStepRouteList();
        }

        //GET : https://localhost:44309/api/step_route/delete?...
        [HttpGet]
        [Route("Delete")]
        public IHttpActionResult deleteStepRoute(string PROCESS_ID, string STEP_ID)
        {
            WebMessage msg = new WebMessage();

            StepDAC db = new StepDAC();
            bool result = db.deleteStepRoute(new StepRouteVO { PROCESS_ID = PROCESS_ID, STEP_ID = STEP_ID });

            if (result)
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "성공적으로 삭제되었습니다.";
            }
            else
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "삭제 중 오류가 발생했습니다.";
            }
            return Ok(msg);
        }
    }
}
