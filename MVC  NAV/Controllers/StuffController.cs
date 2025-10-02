using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC__NAV.Controllers
{
    public class StuffController : Controller
    {
        // GET: Stuff
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Links()
        {
            return View();
        }
        public ActionResult Nav()
        {
            return View();
        }
    }
}