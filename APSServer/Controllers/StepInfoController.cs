using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APSVO;
using APSServer.Models;

namespace APSServer.Controllers
{
    [RoutePrefix("api/StepInfo")]
    public class StepInfoController : ApiController
    {
        //      //Post : https://localhost:44309/api/StepInfo
        //      public void PostStdStep(STD_STEP_VO stepInfolist)
        //{
        //          STEP_INFO_DAC db = new STEP_INFO_DAC();
        //          bool result = db.saveStepInfoList(stepInfolist);
        //}

        //Post : https://localhost:44309/api/StepInfo/saveStdStep
        [HttpPost]
        [Route("saveStdStep")]
        public IHttpActionResult saveStdStep(STD_STEP_VO stepInfolist)
        {
            WebMessage msg = new WebMessage();
            STEP_INFO_DAC db = new STEP_INFO_DAC();
            bool result = db.saveStepInfoList(stepInfolist);

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
    }
}
