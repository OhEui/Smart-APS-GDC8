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
    [RoutePrefix("api/Step")]
    public class StepController : ApiController
    {
        //      //Post : https://localhost:44309/api/Step
        //      public void PostStdStep(STD_STEP_VO stepInfolist)
        //{
        //          STEP_INFO_DAC db = new STEP_INFO_DAC();
        //          bool result = db.saveStepInfoList(stepInfolist);
        //}


        //STD_STEP_INFO

        //Post : https://localhost:44309/api/Step/saveStdStep
        [HttpPost]
        [Route("saveStdStep")]
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

        //GET : https://localhost:44309/api/Step/getStepInfoList
        [HttpGet]
        [Route("getStepInfoList")]
        public List<STD_STEP_VO> getStepInfoList()
		{
            StepDAC db = new StepDAC();
            return db.getStepInfoList();
        }

        //==================================================================================
        //STEP_ROUTE

        ////Post : https://localhost:44309/api/Step/saveStepRoute
        [HttpPost]
        [Route("saveStepRoute")]
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


        //GET : https://localhost:44309/api/Step/getStepRouteList
        [HttpGet]
        [Route("getStepRouteList")]
        public List<StepRouteVO> getStepRouteList()
        {
            StepDAC db = new StepDAC();
            return db.getStepRouteList();
        }

        //GET : https://localhost:44309/api/Step/getStepType
        [HttpGet]
        [Route("getStepType")]
        public List<ComboItemVO> getStepType()
        {
            StepDAC db = new StepDAC();
            return db.getStepType();
        }

        //GET : https://localhost:44309/api/Step/getComboItem
        [HttpGet]
        [Route("getComboItem")]
        public List<ComboItemVO> getComboItem()
        {
            StepDAC db = new StepDAC();
            return db.getComboItem();
        }
    }
}
