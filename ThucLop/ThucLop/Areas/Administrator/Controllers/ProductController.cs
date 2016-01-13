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
           //if(ModelState.IsValid)
           //{
           //    Product pro = new Product();
           //    string Name = connect["Name"];
           //    string Picture = connect["Picture"];
           //    int CategoryId = int.Parse(connect["CategoryId"]);
           //    DateTime ProductDate = DateTime.Parse(connect["ProductDate"]);
           //    int UnitBrief = int.Parse(connect["UnitBrief"]);
           //    int Quantity = int.Parse(connect["Quantity"]);
           //    string Description = connect["Description"];
           //    pro.Name = Name;
           //    pro.Image = Picture;
           //    pro.CategoryId = CategoryId;
           //    pro.ProductDate = ProductDate;
           //    pro.UnitPrice = UnitBrief;
           //    pro.Quantity = Quantity;
           //    pro.Description = Description;
           //    db.Products.Add(pro);
           //    db.SaveChanges();
           //}
            return View("Index");
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