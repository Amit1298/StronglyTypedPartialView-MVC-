using StronglyTypedPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedPartialView.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        List<Product> ProductsList = new List<Product>()
        {
            new Product{id=1,name="Reebok Shoes",price=1000.00,picture="~/Images/ReebokShoes.jpg"},
            new Product{id=2,name="Rayben SunGlasses",price=2000.00,picture="~/Images/Rayben.jpg"},
            new Product{id=3,name="Rolex Watch",price=4000.00,picture="~/Images/rolex.jpg"}
        };
        public ActionResult Index()
        {
            return View(ProductsList);
        }
    }
}