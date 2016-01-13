using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ThucLop.Areas.Administrator.Controllers
{
    public class NewsAdminController : Controller
    {
        //
        // GET: /Administrator/NewsAdmin/
        public ActionResult ViewNews()
        {
            return View();
        }
        public ActionResult _CreateNews()
        {
            return View();
        }
        public ActionResult _EditNews()
        {
            return View();
        }
        public ActionResult _DeleteNews()
        {
            return View();
        }
	}
}