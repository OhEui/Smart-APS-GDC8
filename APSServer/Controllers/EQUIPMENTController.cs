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

        //GET : https://localhost:44309/api/EQUIPMENT/GetEquipments
        [HttpGet]
        [Route("GetEquipments")]
        public List<EQUIPVO> GetAllEquipment()
        {

            EQUIPDAC dac = new EQUIPDAC();
            return dac.GetAllEquipment();
        }

        



        public void InsertEquip(EQUIPVO vo)
        {
            EQUIPDAC dac = new EQUIPDAC();
            dac.InsertEquip(vo);
        }

        public void UpdateEquip(EQUIPVO vo)
        {
            EQUIPDAC dac = new EQUIPDAC();
            dac.UpdateEquip(vo);
        }
    }

}
