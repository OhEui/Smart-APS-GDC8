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
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        //POST : http://localhost:58802/api/Product/SaveProduct

        [HttpPost]
        [Route("SaveProduct")]
        public IHttpActionResult SaveProduct(ProductVO product)
        {
            WebMessage msg = new WebMessage();

            ProductDAC db = new ProductDAC();
            bool result = db.SaveProduct(product);
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

        //GET :  http://localhost:58802/api/Product/Products
        [HttpGet]
        [Route("Products")]
        
        [Authorize]
        public List<ProductVO> GetAllProduct()
        {
            ProductDAC db = new ProductDAC();
            return db.GetAllProduct();
        }

        //GET : http://localhost:58802/api/Product/{id}
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult GetProductInfo(string id)
        {
            ProductDAC db = new ProductDAC();
            ProductVO pr = db.GetDetail(id);

            Message<ProductVO> msg = new Message<ProductVO>();
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

        //GET : http://localhost:58802/api/Product/Delete/{id}
        [HttpGet]
        [Route("Delete/{id}")]
        public IHttpActionResult DeleteProduct(string id)
        {
            ProductDAC db = new ProductDAC();
            bool result = db.DeleteProduct(id);

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

        //GET : http://localhost:58802/api/Product/CommonCode
        [HttpGet]
        [Route("CommonCode")]
        public List<CommonVO> GetCommonCode()
        {
            ProductDAC dac = new ProductDAC();
            return dac.GetCommonCode();
        }
    }
}
