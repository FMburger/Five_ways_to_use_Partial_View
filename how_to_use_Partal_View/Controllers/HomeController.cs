using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace how_to_use_Partal_View.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Method1()
        {
            return View();
        }

        public ActionResult Method2()
        {
            return View();
        }

        public ActionResult Method3()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult M3_Child()
        {
            return PartialView("_PartialView");
        }

        public ActionResult Method4()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult M4_Child()
        {
            return PartialView("_PartialView");
        }

        public ActionResult Method5()
        {
            return View();
        }
        public ActionResult M5_Partial_View()
        {
            return PartialView("_PartialView");
        }
    }
}