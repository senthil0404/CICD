﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CICDSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //HelperLibrary.Customer ob = new HelperLibrary.Customer();
            //ob.GetCustomer();
            return View();
        }
    }
}