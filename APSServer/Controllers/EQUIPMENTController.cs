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
    [RoutePrefix("api/EQUIPMENT")]
    public class EQUIPMENTController : ApiController
    
    {

        //GET : https://localhost:44309/api/EQUIPMENT/EQPlist
        [HttpGet]
        [Route("EQPlist")]
        public List<EQUIPVO> GetAllEquipment()
        {
            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetAllEquipment();
        }

        //GET : https://localhost:44309/api/EQUIPMENT/Linelist
        [HttpGet]
        [Route("Linelist")]
        public List<LineVO> GetLineInfo()
        {

            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetLineInfo();
        }

        //GET : https://localhost:44309/api/EQUIPMENT/ARRlist
        [HttpGet]
        [Route("ARRlist")]
        
            public List<EqpArrangeVO> GetEquipmentARR()
        {
            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetEqipmentARR();
        }

        

        //Post : https://localhost:44309/api/EQUIPMENT/EQPnew
        [HttpPost]
        [Route("EQPnew")]
        public IHttpActionResult InsertEqp(EQUIPVO vo)
        {
            WebMessage msg = new WebMessage();
            EQUIPDAC db = new EQUIPDAC();
            bool result = db.InsertEquip(vo);

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



        ////Post : https://localhost:44309/api/EQUIPMENT/EQPUpdate
        //[HttpPost]
        //[Route("EQPUpdate")]
        //public IHttpActionResult UpdateEqp(EQUIPVO Evo)
        //{
        //    WebMessage msg = new WebMessage();
        //    EQUIPDAC db = new EQUIPDAC();
        //    bool result = db.UpdateEquip(Evo);

        //    if (result)
        //    {
        //        msg.IsSuccess = true;
        //        msg.ResultMessage = "성공적으로 수정되었습니다.";
        //    }
        //    else
        //    {
        //        msg.IsSuccess = false;
        //        msg.ResultMessage = "저장 중 오류가 발생했습니다.";
        //    }
        //    return Ok(msg);
        //}

        //-----------------------------------------------------------------------------------------//
        
        //Post : https://localhost:44309/api/EQUIPMENT/EQPArrnew
        [HttpPost]
        [Route("EQPArrnew")]
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

        ////Post : https://localhost:44309/api/EQUIPMENT/EQPArrUpdate
        //[HttpPost]
        //[Route("EQPArrUpdate")]
        //public IHttpActionResult UpdateEqpArr(EqpArrangeVO Evo)
        //{
        //    WebMessage msg = new WebMessage();
        //    EQUIPDAC db = new EQUIPDAC();
        //    bool result = db.UpdateEquipArr(Evo);

        //    if (result)
        //    {
        //        msg.IsSuccess = true;
        //        msg.ResultMessage = "성공적으로 수정되었습니다.";
        //    }
        //    else
        //    {
        //        msg.IsSuccess = false;
        //        msg.ResultMessage = "저장 중 오류가 발생했습니다.";
        //    }
        //    return Ok(msg);
        //}

        //Post:     https://localhost:44309/api/EQUIPMENT/DelEQP/EQPID
        [HttpGet]
        [Route("DelEQP/{EQPID}")]
        public IHttpActionResult deleteEQP(string EQPID)
        {
            WebMessage msg = new WebMessage();

            EQUIPDAC db = new EQUIPDAC();
            bool result = db.deleteEQP(EQPID);

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


        //Post:     https://localhost:44309/api/EQUIPMENT/DelEQPARR/EQPARRID
        [HttpGet]
        [Route("DelEQPARR")]
        public IHttpActionResult deleteEQPARR(string PRODUCT_ID, string PROCESS_ID, string STEP_ID, string EQP_ID)
        {
            WebMessage msg = new WebMessage();

            EQUIPDAC db = new EQUIPDAC();
            bool result = db.deleteEQPARR(new EqpArrangeVO { PRODUCT_ID= PRODUCT_ID, PROCESS_ID = PROCESS_ID, STEP_ID= STEP_ID,EQP_ID=EQP_ID });

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
