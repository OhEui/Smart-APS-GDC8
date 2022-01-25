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
    [RoutePrefix("api/SETUP_TIME")]
    public class SetUpController : ApiController
    {
        //GET : https://localhost:44309/api/SETUP_TIME/SetupList
        [HttpGet]
        [Route]
        public List<SetupVO> GetSetup_time()
        {
            SETUPDAC dac = new SETUPDAC();
            return dac.GetSetup_time();
        }

        //Post : https://localhost:44309/api/SETUP_TIME/SetupNew
        [HttpPost]
        [Route("save")]
        public IHttpActionResult InsertSetup(SetupVO vo)
        {
            WebMessage msg = new WebMessage();
            SETUPDAC db = new SETUPDAC();
            bool result = db.InsertSetup(vo);

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

        //Get :  https://localhost:44309/api/SETUP_TIME/DelSetup/SetupID
        [HttpGet]
        [Route("delete")]
        public IHttpActionResult deleteSetup(string SITE_ID, string LINE_ID, string EQP_GROUP, string STEP_ID)
        {
            
            WebMessage msg = new WebMessage();

            SETUPDAC db = new SETUPDAC();
            bool result = db.deleteSetup(new SetupVO { SITE_ID = SITE_ID, LINE_ID = LINE_ID, EQP_GROUP = EQP_GROUP, STEP_ID = STEP_ID });
           
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
