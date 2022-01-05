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

        //GET :  http://localhost:58802/api/Product/Productlist
        [HttpGet]
        [Route("Productlist")]
        public List<ProductVO> GetAllProduct()
        {
            ProductDAC db = new ProductDAC();
            return db.GetAllProduct();
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
                msg.ResultMessage = "성공적으로 등록되었습니다.";
            }
            else
            {
                msg.IsSuccess = false;
                msg.ResultMessage = "저장 중 오류가 발생했습니다.";
            }
            return Ok(msg);
        }



        //Post : https://localhost:44309/api/EQUIPMENT/EQPUpdate
        [HttpPost]
        [Route("EQPUpdate")]
        public IHttpActionResult UpdateEqp(EQUIPVO Evo)
        {
            WebMessage msg = new WebMessage();
            EQUIPDAC db = new EQUIPDAC();
            bool result = db.UpdateEquip(Evo);

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

        //Post : https://localhost:44309/api/EQUIPMENT/EQPArrUpdate
        [HttpPost]
        [Route("EQPArrUpdate")]
        public IHttpActionResult UpdateEqpArr(EqpArrangeVO Evo)
        {
            WebMessage msg = new WebMessage();
            EQUIPDAC db = new EQUIPDAC();
            bool result = db.UpdateEquipArr(Evo);

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

       


    }


}
