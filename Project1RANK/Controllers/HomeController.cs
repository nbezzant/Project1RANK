using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1RANK.Models;


namespace Project1RANK.Controllers
{
    public class HomeController : Controller
    {
        public static List<string> lstSubject = new List<string>();
        
        
        
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
            lstSubject.Add("Question");
            lstSubject.Add("Test1");
            lstSubject.Add("Test2");
            ViewBag.Subjects = lstSubject;
            return View();
        }

        public ActionResult GetSaved()
        {
            return Redirect("https://www.churchofjesuschrist.org/?lang=eng");
        }

    }
}