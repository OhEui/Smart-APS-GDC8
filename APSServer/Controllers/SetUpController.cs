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
            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetSetup_time();
        }
    }
}
