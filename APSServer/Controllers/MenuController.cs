using APSServer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APSVO;
namespace APSServer.Controllers
{
    [RoutePrefix("api/Menu")]
    public class MenuController : ApiController
    {
        MenuDAC db = new MenuDAC();

        //GET : https://localhost:44309/api/Menu/Menulist
        [HttpGet]
        [Route("Menulist")]

        public List<MenuVO> GetMenuList()
        {
            MenuDAC dac = new MenuDAC();
            return dac.GetMenuList();
        }

        //public void GetMenuList()
        //{
        //    MenuDAC dac = new MenuDAC();
        //    GetMenuList();
        //}


        //private void LoadData()
        //{
        //    MenuDAC dac = new MenuDAC();
        //    return dac.GetUserMenuList();
        //}

    }
}
