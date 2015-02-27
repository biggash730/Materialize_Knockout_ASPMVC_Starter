using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace vls.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            if (User.Identity.GetUserId() == null) RedirectToAction("Login");
            return View();
            //return User.Identity.GetUserId() != null ? View("Index") : View("Login");
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Reset()
        {
            return View();
        }
    }
}
