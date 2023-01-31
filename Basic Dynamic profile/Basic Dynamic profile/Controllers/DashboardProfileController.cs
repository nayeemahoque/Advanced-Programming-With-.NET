using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Basic_Dynamic_profile.Controllers
{
    public class DashboardProfileController : Controller
    {
        // GET: DashboardProfile
        public ActionResult MyProfile()
        {
            TempData["Msg"] = "Login Successfull";
            return View();
        }
        public ActionResult Settings()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Home", "BasicProfile");
        }
    }
}