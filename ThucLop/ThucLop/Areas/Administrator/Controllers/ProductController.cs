using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using ThucLop.Models;

namespace ThucLop.Areas.Administrator.Controllers
{
    public class ProductController : Controller
    {
        //ThucLopEntities db = new ThucLopEntities();
        public ActionResult ViewProduct()
        {
            //var product = db.Products.ToList();
            return View();
        }
        public ActionResult _CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult _CreateProduct( FormCollection connect)
        {

            return View();
        }
        public ActionResult _EditProduct( int id=0)
        {

            return View();
        }
        [HttpPost]
        public ActionResult _EditProduct(FormCollection connect, int id=0)
        {

            return View();
        }
        public ActionResult _DeleteProduct(int id=0 )
        {

            return View();
        }
        [HttpPost]
        public ActionResult _DeleteProductConfirmed(int id = 0)
        {

            return View();
        }
	}
}