using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork_1.Controllers
{
    public class AnotherController : Controller
    {
        // GET: Another
        public ActionResult Info()
        {
            return View();
        }

        public ActionResult DoNotOpen()
        {
            return View();
        }

    }
}