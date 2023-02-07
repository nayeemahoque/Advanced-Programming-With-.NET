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
            ViewBag.Title = "Home";
            ViewBag.Name = "Nayeema";
            ViewBag.ID = "20-43737-2";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
            //return Redirect("https://dotnet.microsoft.com/en-us/apps/aspnet");
        }
        public ActionResult Login()
        {
            ViewBag.Title = "Login";
            return View();
        }
        public ActionResult signup()
        {
            ViewBag.Title = "SignUp";
            return View();
        }
        public ActionResult LoginSubmit()
        {
            TempData["Msg"] = "Login Successfull";
            return RedirectToAction("MyProfile, DashboardProfile");
        }

    }
}