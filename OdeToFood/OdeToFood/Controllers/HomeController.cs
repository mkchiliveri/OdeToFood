﻿using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        OdeToFoodDB _db = new OdeToFoodDB(); 

        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is home controller.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if(_db!=null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}