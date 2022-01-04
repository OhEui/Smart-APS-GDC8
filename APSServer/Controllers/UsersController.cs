using APSServer.Filters;
using APSServer.Models;
using APSVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace APSServer.Controllers
{
    [RoutePrefix("api/User")]
    public class UsersController : ApiController
    {
        #region GET Method
        [HttpGet]
        [Route("CheckID")]
        public WebMessage CheckID(string id)
        {
            var msg = new WebMessage();

            using (UserDAC dac = new UserDAC())
            {
                var bCheck = dac.CheckID(id);
                if (bCheck)
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "사용 중인 ID입니다.";
                }
                else
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "사용 가능한 ID입니다.";
                }
                return msg;
            }
        }

        [HttpGet]
        [Route("CheckEmail")]
        public WebMessage CheckEmail(string Email)
        {
            var msg = new WebMessage();

            using (UserDAC dac = new UserDAC())
            {
                var bCheck = dac.CheckEmail(Email);
                if (bCheck)
                {
                    msg.IsSuccess = false;
                    msg.ResultMessage = "사용 중인 Email입니다.";
                }
                else
                {
                    msg.IsSuccess = true;
                    msg.ResultMessage = "사용 가능한 Email입니다.";
                }
                return msg;
            }
        }
        #endregion

        #region POST Method
        [HttpPost][Route("Login")]
        public WebMessage<UserVerify> Login(ReqUserLogin req)
        {
            var msg = new WebMessage<UserVerify>();
            string id = req.ID;
            string password = req.Password;

            using (UserDAC dac = new UserDAC())
            {
                var data = dac.Login(id, password);
                if (data != null)
                {
                    byte[] bytes = Encoding.UTF8.GetBytes($"{id}:{password}");
                    data.AuthHeader = Convert.ToBase64String(bytes);

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

        [HttpPost]
        [Route("SignUp")]
        public WebMessage SignUp(UserInfo info)
        {
            //var msg = new WebMessage<UserLogin>();
            using (UserDAC dac = new UserDAC())
            {
                var res = dac.SignUp(info);
                return res;
            }
        }
        [HttpPost]
        [Route("ResetPassword")]
        public WebMessage ResetPassword(ReqUserResetPassword req)
        {
            // 랜덤 비밀번호 생성 - DB에 저장 - 이메일 전송
            throw new NotImplementedException();
        }


        [HttpPost][Route("Logout")][UserAuthentication][Authorize]
        public WebMessage Logout(UserData data) 
        {
            // 쿠키, 세션 해제 작업을 함 (DB 접근 없음)
            throw new NotImplementedException();
        }



        [HttpPost][Route("UpdateUserInfo")][UserAuthentication][Authorize]
        public WebMessage<UserData> UpdateUserInfo(ReqUserUpdateInfo req) 
        {
            string curId = req.Cur_ID;
            string curPassword = req.Cur_PWD;
            UserInfo newInfo = req.NewInfo;

            using (UserDAC dac = new UserDAC()) 
            {
                var res = dac.UpdateUserInfo(curId, curPassword, newInfo);
                return res;
            }

        }

        [HttpPost][Route("WithDraw")][UserAuthentication][Authorize]
        public WebMessage WithDraw(ReqUserLogin req) 
        {
            string curId = req.ID;
            string curPassword = req.Password;

            using (UserDAC dac = new UserDAC())
            {
                var res = dac.WithDraw(curId, curPassword);
                return res;
            }
        }
        #endregion
    }
}
