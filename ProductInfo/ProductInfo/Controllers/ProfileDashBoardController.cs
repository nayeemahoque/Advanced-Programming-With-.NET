using ProductInfo.Models;
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
            Product[] allProducts = new Product[10];

            allProducts[0] = new Product("P001", "Ice-cream", 75);
            allProducts[1] = new Product("P002", "Chocolate", 100);
            allProducts[2] = new Product("P003", "Juice", 30);
            allProducts[3] = new Product("P003", "Chips", 20);
            allProducts[4] = new Product("P004", "Biscuit", 50);
            allProducts[5] = new Product("P005", "cake", 120);
            allProducts[6] = new Product("P006", "Drinko", 35);
            allProducts[7] = new Product("P007", "Pringles", 275);
            allProducts[8] = new Product("P008", "Lays", 60);
            allProducts[9] = new Product("P009", "Noodles", 180);

            ViewBag.AllProducts = allProducts;

            return View();
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Home", "Products");
        }
    }
}