using NM.Web.WebApplication.Timesheets.United.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NM.Web.WebApplication.Timesheets.Controllers
{
    public class BaseController : Controller
    {
        public int numberOfYearsToGenerateBasedOnCurrentYear = int.Parse(ConfigurationManager.AppSettings["NumberOfYearsToGenerateBasedOnCurrentYear"]);
        public IRepository repository;

        public string CurrentLoginUserName;

        //// GET: Base
        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}