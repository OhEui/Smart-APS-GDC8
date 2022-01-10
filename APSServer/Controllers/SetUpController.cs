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
    [RoutePrefix("api/SETUP_TIME")]
    public class SetUpController : ApiController
    {
        //GET : https://localhost:44309/api/SETUP_TIME/SetupList
        [HttpGet]
        [Route("SetupList")]
        public List<SetupVO> GetSetup_time()
        {
            SETUPDAC dac = new SETUPDAC();
            return dac.GetSetup_time();
        }

        //Post : https://localhost:44309/api/SETUP_TIME/SetupNew
        [HttpPost]
        [Route("SetupNew")]
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
    }
}
