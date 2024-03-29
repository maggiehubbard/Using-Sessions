﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab225.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login(string username, string password, string color)
        {
            ViewBag.FullName = username;
            ViewBag.Password = password;
            ViewBag.Color = color;

            Session["username"] = username;
            Session["password"] = password;
            Session["color"] = color;

            return View();
        }
        public ActionResult Logout()//make a new view for this
        {
            Session.Clear();
            return View();
        }
    
    }
}