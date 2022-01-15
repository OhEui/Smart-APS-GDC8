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
    [RoutePrefix("api/Common")]
    public class CommonController : ApiController
    {
        //GET : https://localhost:44309/api/Common/CommonCode
        [HttpGet]
        [Route("CommonCode")]
        public List<ComboItemVO> GetComboItem()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetComboItem();
        }

        ////GET : https://localhost:44309/api/Common/GetCode
        //[HttpGet]
        //[Route("GetCode")]
        //public List<ComboItemVO> GetCodeList(string[] categories)
        //{
        //    CommonDAC dac = new CommonDAC();
        //    return dac.GetCodeList(categories);
        //}
    }
}
