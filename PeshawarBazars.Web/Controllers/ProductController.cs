using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeshawarBazar.Services;
namespace PeshawarBazars.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductServie services = new ProductServie();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Producttable()
        {
            var products = services.GetProduct();

            return View(products);
        }
    }
}