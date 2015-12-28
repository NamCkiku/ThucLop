using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThucLop.Models;

namespace ThucLop.Areas.Administrator.Controllers
{
    public class ProductController : Controller
    {
        ThucLopEntities db = new ThucLopEntities();
        public ActionResult ViewProduct()
        {
            var product = db.Products.ToList();
            return View(product);
        }
        public ActionResult CreateProduct()
        {
            
            return View();
        }
	}
}