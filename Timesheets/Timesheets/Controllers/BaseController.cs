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
        public Models.ViewModel.MasterUserViewModel _masterUserViewModel;

        //// GET: Base
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public Models.ViewModel.MasterUserViewModel MasterUser
        {
            get
            {
                var currentUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                //var currentUser = "UPROPERTIES\\test123";
                var _masterUser = new Models.ViewModel.MasterUserViewModel();
                var model = repository.GetMasterUser(currentUser);
                if (model != null)
                {
                    _masterUser = AutoMapper.Mapper.Map(model, new Models.ViewModel.MasterUserViewModel());
                    return _masterUser;
                }
                return null;
            }
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            //Logging the Exception
            filterContext.ExceptionHandled = true;

            var Result = this.View("Error", new HandleErrorInfo(exception,
                filterContext.RouteData.Values["controller"].ToString(),
                filterContext.RouteData.Values["action"].ToString()));

            ViewBag.CurrentEnvironment = Properties.Settings.Default.CurrentEnvironment.ToLower();

            filterContext.Result = Result;

            //base.OnException(filterContext);
        }
    }
}