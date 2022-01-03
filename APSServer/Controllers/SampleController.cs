﻿using System;
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
    [RoutePrefix("api/Sample")][UserAuthentication][Authorize]
    public class SampleController : ApiController
    {
        // https://localhost:44309/api/Sample/List
        [HttpPost]
        [Route("List")]
        public WebMessage<List<SampleVO>> GetList()
        {
            var msg = new WebMessage<List<SampleVO>>();

            // APIController에서 로그인한 유저의 ID를 얻는법
            // 컨트롤러에 [UserAuthentication][Authorize]가 적용되어 있어야 함
            string userID = (RequestContext.Principal as UserPrincipal)?.User_ID ?? null;

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
