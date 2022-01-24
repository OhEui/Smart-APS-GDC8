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
        /// <summary>
        /// 권한정보를 불러옵니다.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAuth")]
        public List<AuthVO> GetAllAuth()
        {
            AuthDAC dac = new AuthDAC();
            return dac.GetAllAuth();
        }



        //GET : https://localhost:44309/api/Auth/GetUser
        /// <summary>
        /// 유저 리스트를 불러옵니다.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUser")]
        public List<UserVO> GetAllUser()
        {
            UserDAC dac = new UserDAC();
            return dac.GetAllUser();
        }

        //Post : https://localhost:44309/api/Auth/AuthSave
        /// <summary>
        /// 설정한 유저권한을 저장합니다.
        /// </summary>
        /// <param name="vo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AuthSave")]
        public IHttpActionResult SaveAuth(UserVOs vo)
        {
            WebMessage msg = new WebMessage();
            AuthDAC db = new AuthDAC();
            bool result = db.SaveAuth(vo);

            if (result)
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "성공적으로 저장되었습니다.";
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

