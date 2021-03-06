﻿using MVC5Course.ActionFilter;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    [LocalOnly]
    public class HomeController : Controller
    {
        [ShareData]
        public ActionResult Index()
        {
            return View();
        }

        [ShareData]
        public ActionResult About()
        {
            return View();
        }

        [ShareData]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VT()
        {
            return PartialView();
        }

        public ActionResult MetroIndex()
        {
            return View();
        }
    }
}