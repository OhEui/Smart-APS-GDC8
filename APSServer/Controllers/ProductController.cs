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
                msg.ResultMessage = "성공적으로 저장!";
            }
            else
            {
                msg.IsSuccess = true;
                msg.ResultMessage = "저장 중 오류 발생!";
            }
            return Ok(msg);
        }

        //GET :  http://localhost:58802/Product
        [HttpGet]
        [Route("Product")]
        public List<ProductVO> GetAllProduct()
        {
            ProductDAC db = new ProductDAC();
            return db.GetAllProduct();
        }

    }
}
