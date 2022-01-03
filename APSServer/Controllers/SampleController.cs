using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using APSServer.Filters;
using APSServer.Models;
using APSServer.Principal;
using APSVO;

namespace APSServer.Controllers
{
    [RoutePrefix("api/Sample")][Authorize][UserAuthentication]
    public class SampleController : ApiController
    {
        // https://localhost:44309/api/Sample/List
        [HttpPost]
        [Route("List")]
        public WebMessage<List<SampleVO>> GetList()
        {
            var msg = new WebMessage<List<SampleVO>>();

            //Logger.APILogger(RequestContext.Principal, Request);

            using (SampleDAC dac = new SampleDAC())
            {
                var data = dac.GetSampleList();
                if (data != null)
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "Hello World";
                    msg.Data = data;
                }
                else
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "Fail";
                    msg.Data = null;
                }
                return msg;
            }
        }
    }
}
