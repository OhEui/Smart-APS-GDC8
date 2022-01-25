using APSServer.Filters;
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
    [Authorize]
    [APILogger]
    [RoutePrefix("api/eqp_arrange")]
    public class EqpArrangeController : ApiController
    {
        //GET : https://localhost:44309/api/EQUIPMENT/ARRlist
        [HttpGet]
        [Route]

        public List<EqpArrangeVO> GetEquipmentARR()
        {
            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetEqipmentARR();
        }

        //Post : https://localhost:44309/api/EQUIPMENT/EQPArrnew
        [HttpPost]
        [Route("save")]
        public IHttpActionResult InsertEqpArr(EqpArrangeVO vo)
        {
            WebMessage msg = new WebMessage();
            EQUIPDAC db = new EQUIPDAC();
            bool result = db.InsertEquipArr(vo);

            if (result)
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "성공적으로 등록되었습니다.";
            }
            else
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "저장 중 오류가 발생했습니다.";
            }
            return Ok(msg);
        }

        //Get: https://localhost:44309/api/EQUIPMENT/DelEQPARR/EQPARRID
        [HttpGet]
        [Route("delete")]
        public IHttpActionResult deleteEQPARR(string PRODUCT_ID, string PROCESS_ID, string STEP_ID, string EQP_ID)
        {
            WebMessage msg = new WebMessage();

            EQUIPDAC db = new EQUIPDAC();
            bool result = db.deleteEQPARR(new EqpArrangeVO { PRODUCT_ID = PRODUCT_ID, PROCESS_ID = PROCESS_ID, STEP_ID = STEP_ID, EQP_ID = EQP_ID });

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
