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

    [RoutePrefix("api/Auth")]
    public class AuthController : ApiController
    {
        //GET : https://localhost:44309/api/Auth/GetAuth
        [HttpGet]
        [Route("GetAuth")]
        public List<AuthVO> GetAllAuth()
        {
            AuthDAC dac = new AuthDAC();
            return dac.GetAllAuth();
        }



        //GET : https://localhost:44309/api/Auth/GetUser
        [HttpGet]
        [Route("GetUser")]
        public List<UserVO> GetAllUser()
        {
            UserDAC dac = new UserDAC();
            return dac.GetAllUser();
        }
    }
}

