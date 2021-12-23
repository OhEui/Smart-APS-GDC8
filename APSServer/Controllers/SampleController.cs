using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using APSServer.Models;
using APSVO;

namespace APSServer.Controllers
{
    [RoutePrefix("api/Sample")]
    public class SampleController : ApiController
    {
        // https://localhost:44309/api/Sample/List
        [HttpGet]
        [Route("List")]
        public List<SampleVO> GetList()
        {
            using (SampleDAC dac = new SampleDAC()) 
            {
                return dac.GetSampleList();
            }
        }

    }
}
