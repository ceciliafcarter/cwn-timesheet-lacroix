﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NM.Web.WebApplication.Timesheets.Controllers
{
    public class OverViewController : Controller
    {
        // GET: OverView
        public ActionResult Index()
        {
            return View("OverviewView");
        }
    }
}