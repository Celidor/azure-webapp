using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_get_started.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A Cloud Guru";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hello Cloud Gurus. Let's get in touch ...";

            return View();
        }
    }
}