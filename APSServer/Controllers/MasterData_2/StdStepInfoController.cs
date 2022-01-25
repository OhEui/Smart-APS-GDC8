using APSServer.Filters;
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
    [Authorize]
    [APILogger]
    [RoutePrefix("api/std_step_info")]
    public class StdStepInfoController : ApiController
    {
        //Post : https://localhost:44309/api/std_step_info/save
        [HttpPost]
        [Route("save")]
        public IHttpActionResult saveStdStep(STD_STEP_VO stepInfolist)
        {
            WebMessage msg = new WebMessage();
            StepDAC db = new StepDAC();
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

        //GET : https://localhost:44309/api/std_step_info
        [HttpGet]
        [Route]
        public List<STD_STEP_VO> getStepInfoList()
        {
            StepDAC db = new StepDAC();
            return db.getStepInfoList();
        }

        //GET : https://localhost:44309/api/std_step_info/delete/stepID
        [HttpGet]
        [Route("Delete/{id}")]
        public IHttpActionResult deleteStepInfo(string id)
        {
            WebMessage msg = new WebMessage();

            StepDAC db = new StepDAC();
            bool result = db.deleteStepInfo(id);

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
