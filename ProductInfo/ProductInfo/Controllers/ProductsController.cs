using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductInfo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LoginSubmit()
        {
            return RedirectToAction("ProductsProfile, ProfileDashBoard");
        }
    }
}