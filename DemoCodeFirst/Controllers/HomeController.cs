using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoCodeFirst.Dbcontext;

namespace DemoCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        SchoolDbcontext SchoolDbcontext = new SchoolDbcontext();
        public ActionResult Index()
        {
            var dd = SchoolDbcontext.Departments.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return Json(false);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}