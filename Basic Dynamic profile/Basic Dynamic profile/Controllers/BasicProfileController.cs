using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Basic_Dynamic_profile.Controllers
{
    public class BasicProfileController : Controller
    {
        // GET: BasicProfile
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return Redirect("https://dotnet.microsoft.com/en-us/apps/aspnet");
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult signup()
        {
            return View();
        }
    }
}