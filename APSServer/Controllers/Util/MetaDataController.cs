using APSServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APSServer.Controllers
{
    [RoutePrefix("api/MetaData")]
    public class MetaDataController : ApiController
    {
        [HttpGet]
        [Route("Delete")]
        public IHttpActionResult GetExcelData()
        {
            // 차트 데이터 가져오기
            using (MetaDataDAC dac = new MetaDataDAC())
            {
                var data = dac.GetData();
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
