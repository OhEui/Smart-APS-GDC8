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
    [RoutePrefix("api/Step")]
    public class StepController : ApiController
    {
        //      //Post : https://localhost:44309/api/Step
        //      public void PostStdStep(STD_STEP_VO stepInfolist)
        //{
        //          STEP_INFO_DAC db = new STEP_INFO_DAC();
        //          bool result = db.saveStepInfoList(stepInfolist);
        //}

        #region STEP_ROUTE
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

        #endregion
    }
}
