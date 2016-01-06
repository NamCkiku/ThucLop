using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThucLop.Areas.Administrator.Controllers
{
    public class StatisticalController : Controller
    {
        //
        // GET: /Administrator/Statistical/
        public ActionResult StatisticalProduct()
        {
            return View();
        }
        public ActionResult StatisticalNews()
        {
            return View();
        }
	}
}