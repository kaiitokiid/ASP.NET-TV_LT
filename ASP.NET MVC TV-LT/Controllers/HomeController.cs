using ASP.NET_MVC_TV_LT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_TV_LT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id)
        {
            MyModel myobj = new MyModel();
            myobj.NAME = "Nguyễn Quốc Bảo";
            myobj.PHONE = "0947106062";

            ViewBag.abc = "Your application description page. " + id;

            return View(myobj);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}