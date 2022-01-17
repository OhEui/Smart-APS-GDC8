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

        //Post : https://localhost:44309/api/UserInfo/UserInfoUpdate
        [HttpPost]
        [Route("UserInfoUpdate")]
        public IHttpActionResult UpdateProduct(UserInfoVO prod)
        {
            WebMessage msg = new WebMessage();
            UserDAC db = new UserDAC();
            bool result = db.UpdateUserInfo(prod);

            if (result)
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "성공적으로 수정되었습니다.";
            }
            else
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "저장 중 오류가 발생했습니다.";
            }
            return Ok(msg);

        }


        //GET : https://localhost:44309/api/UserInfo/{id}
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetProductInfo(string id)
        {
            UserDAC db = new UserDAC();
            UserInfoVO pr = db.GetDetail(id);

            Message<UserInfoVO> msg = new Message<UserInfoVO>();
            if (pr != null)
            {
                msg.IsSuccess = true;
                msg.ResultMsg = "성공적으로 조회되었습니다.";
                msg.Data = pr;
            }
            else
            {
                msg.IsSuccess = false;
                msg.ResultMsg = "해당하는 정보가 없습니다.";
                msg.Data = null;
            }
            return Ok(msg);
        }

        //GET : https://localhost:44309/api/UserInfo/Delete/{id}
        [HttpGet]
        [Route("Delete/{id}")]
        public IHttpActionResult DeleteUserInfo(string id)
        {
            UserDAC db = new UserDAC();
            bool result = db.DeleteUserInfo(id);

            WebMessage msg = new WebMessage();
            if (result)
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "성공적으로 삭제되었습니다.";
            }
            else
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "삭제 중 오류가 발생했습니다.";
            }
            return Ok(msg);
        }
    }
}

