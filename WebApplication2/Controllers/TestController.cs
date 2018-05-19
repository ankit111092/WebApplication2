using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        public IEnumerable<Menu> getMenu()
        {

            List<Menu> objmenu = new List<Menu>();

            Menu obj = new Menu();
            obj.MenuID = "1";
            obj.MenuName = "ram";
            objmenu.Add(obj);
            return objmenu;
        }





    }
    public class Menu
    {
        public string MenuID { get; set; }
        public string MenuName { get; set; }
    }

}
