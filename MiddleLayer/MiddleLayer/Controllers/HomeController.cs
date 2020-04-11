using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiddleLayer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Retailebook.com.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "We will be happy to help you!!";

            return View();
        }
    }
}