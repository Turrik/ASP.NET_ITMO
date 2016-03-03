using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeWork_1.Models;

namespace HomeWork_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FavouriteDJs()
        {
            var djs = CreateDJ.CreateDjs();
            return View(djs);
        }
    }
}