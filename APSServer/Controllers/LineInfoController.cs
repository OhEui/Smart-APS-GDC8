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
    [RoutePrefix("api/LineInfo")]
    public class LineInfoController : ApiController
    {
        //POST : https://localhost:44309/api/LineInfo/SaveLineInfo

        [HttpPost]
        [Route("SaveLineInfo")]
        public IHttpActionResult SaveLineInfo(Line_Info_VO line_Info)
        {
            WebMessage msg = new WebMessage();

            LineInfoDAC db = new LineInfoDAC();
            bool result = db.SaveLineInfo(line_Info);
            if (result)
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "성공적으로 저장되었습니다.";
            }
            else
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "저장 중 오류 발생하였습니다.";
            }
            return Ok(msg);
        }

        //Post : https://localhost:44309/api/LineInfo/LineInfoUpdate
        [HttpPost]
        [Route("LineInfoUpdate")]
        public IHttpActionResult UpdateLineInfo(Line_Info_VO Demd)
        {
            WebMessage msg = new WebMessage();
            LineInfoDAC db = new LineInfoDAC();
            bool result = db.UpdateLineInfo(Demd);

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

        //GET :  https://localhost:44309/api/LineInfo/AllList
        [HttpGet]
        [Route("AllList")]
        public List<Line_Info_VO> GetAllLineInfo()
        {
            LineInfoDAC db = new LineInfoDAC();
            return db.GetAllLineInfo();
        }

        //GET : https://localhost:44309/api/LineInfo/{id}
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetLineInfo(string id)
        {
            LineInfoDAC db = new LineInfoDAC();
            Line_Info_VO pr = db.GetDetail(id);

            Message<Line_Info_VO> msg = new Message<Line_Info_VO>();
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

        //GET : https://localhost:44309/api/LineInfo/Delete/{id}
        [HttpGet]
        [Route("Delete/{id}")]
        public IHttpActionResult DeleteLineInfo(string id)
        {
            LineInfoDAC db = new LineInfoDAC();
            bool result = db.DeleteLineInfo(id);

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
