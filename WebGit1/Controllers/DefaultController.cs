using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGit1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Myname = "Text Here2";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.MyAbout = "Text About Here";

            return View();
        }
    }
}