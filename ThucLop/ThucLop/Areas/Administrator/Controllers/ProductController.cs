﻿using System;
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
        public ActionResult _EditProduct()
        {

            return View();
        }
        [HttpPost]
        public ActionResult _EditProduct(FormCollection connect)
        {

            return View();
        }
	}
}