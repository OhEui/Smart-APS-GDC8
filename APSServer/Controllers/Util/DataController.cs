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
    [RoutePrefix("api/Data")]
    public class DataController : ApiController
    {
        /// <summary>
        /// SelectAll 프로시저 호출 -> DataSet에 저장 -> Excel로 변환 -> Response에 파일 넣기
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("all")]
        public IHttpActionResult GetAllData()
        {
            // 차트 데이터 가져오기
            using (ExcelDAC dac = new ExcelDAC())
            {
                var data = dac.GetAllData();
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
        [HttpGet]
        [Route("Conn")]
        public IHttpActionResult GetDeleteConnData()
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
