using Clothbazar.Entities;
using PeshawarBazar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeshawarBazars.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesServie services = new CategoriesServie();

        public ActionResult index()
        {
            var cat = services.GetCategory();
            return View(cat);
        }

        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category category)
        {
            services.SaveCategory(category);
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var cat1 = services.GetCategory(ID);
            return View(cat1);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            services.UpdateCategory(category);
            return RedirectToAction("index");
        }
        public ActionResult Delete(int ID)
        {
            var category = services.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {

          
            services.DeleteCategory(category.ID);
            return Redirect("index");
        }

    }

 
}
