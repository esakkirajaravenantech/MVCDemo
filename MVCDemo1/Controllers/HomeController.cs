using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["nameList"] = new List<string>()
            {
                "Raja",
                "Thilagar",
                "Mahesh",
                "Manoj"
            };
            return View();
        }

    }
}