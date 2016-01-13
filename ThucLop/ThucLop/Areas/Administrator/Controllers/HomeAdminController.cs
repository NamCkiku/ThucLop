using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThucLop.Areas.Administrator.Controllers
{
    public class HomeAdminController : Controller
    {
        //
        // GET: /Administrator/Home/
        public ActionResult Index()
        {
            return View();
        }
	}
}