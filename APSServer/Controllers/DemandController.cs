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
    [RoutePrefix("api/Demand")]
    public class DemandController : ApiController
    {
        //POST : https://localhost:44309/api/Demand/SaveDemand
        /// <summary>
        /// DEMAND 데이터를 추가하거나 수정합니다.
        /// </summary>
        /// <param name="demand"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SaveDemand")]
        public IHttpActionResult SaveDemand(DemandVO demand)
        {
            WebMessage msg = new WebMessage();

            DemandDAC db = new DemandDAC();
            bool result = db.SaveDemand(demand);
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


        //GET :  https://localhost:44309/api/Demand/AllList
        /// <summary>
        /// 모든 DEMAND 데이터를 불러옵니다.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("AllList")]
        public List<DemandVO> GetAllDemand()
        {
            DemandDAC db = new DemandDAC();
            return db.GetAllDemand();
        }

        //GET : https://localhost:44309/api/Demand/{id}
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetDemandInfo(string id)
        {
            DemandDAC db = new DemandDAC();
            DemandVO pr = db.GetDetail(id);

            Message<DemandVO> msg = new Message<DemandVO>();
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

        //GET : https://localhost:44309/api/Demand/Delete/{id}
        /// <summary>
        /// DEMAND 데이터를 삭제합니다.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Delete/{id}")]
        public IHttpActionResult DeleteDemand(string id)
        {
            DemandDAC db = new DemandDAC();
            bool result = db.DeleteDemand(id);

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
