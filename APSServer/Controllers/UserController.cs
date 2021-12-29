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
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("Login")]
        public WebMessage<UserLogin> GetList(string id, string password)
        {
            var msg = new WebMessage<UserLogin>();

            using (UserDAC dac = new UserDAC())
            {
                var data = dac.Login(id, password);
                if (data != null)
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "로그인에 성공하였습니다.";
                    msg.Data = data;
                }
                else
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "로그인 중 오류가 발생하였습니다.";
                    msg.Data = null;
                }
                return msg;
            }
        }
    }
}
