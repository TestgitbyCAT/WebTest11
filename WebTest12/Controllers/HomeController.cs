using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest12.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize(Roles="Admin")]// User0
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        [CustomAuthorize(Roles = "Admin,User")]// User0, User1, User2
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}