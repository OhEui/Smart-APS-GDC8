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
    [RoutePrefix("api/UserInfo")]
    public class UserInfoController : ApiController
    {
        //GET :  https://localhost:44309/api/UserInfo/AllList
        [HttpGet]
        [Route("AllList")]

        public List<UserInfoVO> AllUserList()
        {
            UserDAC dac = new UserDAC();
            return dac.AllUserList();
        }
    }
}

