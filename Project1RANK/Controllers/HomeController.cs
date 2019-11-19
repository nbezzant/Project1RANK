﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1RANK.Models;


namespace Project1RANK.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            return View();
        }


        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetSaved()
        {
            return Redirect("https://www.churchofjesuschrist.org/?lang=eng");
        }

    }
}