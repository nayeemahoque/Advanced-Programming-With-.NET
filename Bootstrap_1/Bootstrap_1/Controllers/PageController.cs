using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bootstrap_1.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FirstPage()
        {
            return View();
        }
        public ActionResult SecondPage()
        {
            return View();
        }
        public ActionResult ThirdPage()
        {
            return View();
        }
    }
}