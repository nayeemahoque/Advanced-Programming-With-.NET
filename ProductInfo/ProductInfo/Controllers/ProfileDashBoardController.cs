using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace ProductInfo.Controllers
{
    public class ProfileDashBoardController : Controller
    {
        // GET: ProfileDashBoard
        public ActionResult ProductsProfile()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Home", "Products");
        }
    }
}