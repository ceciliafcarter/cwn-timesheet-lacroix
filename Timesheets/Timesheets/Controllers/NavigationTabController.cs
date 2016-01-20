using NM.Web.WebApplication.Timesheets.United.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NM.Web.WebApplication.Timesheets.Controllers
{
    public class NavigationTabController : BaseController
    {
        public NavigationTabController(IRepository repo)
        {
            repository = repo;
        }

        #region Actions
        // GET: NavigationTab
        public ActionResult Nav()
        {
            return PartialView("Nav");
        }

        public ActionResult Header()
        {

            if (ViewBag.CurrentUserName != null)
            {
                CurrentLoginUserName = ViewBag.CurrentUserName;
            }
            else
            {
                CurrentLoginUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            }

            var listOfYears = repository.GenerateYearsBasedOnCurrentYear(numberOfYearsToGenerateBasedOnCurrentYear).OrderBy(i => i);
            var timeYears = new List<SelectListItem>();
            foreach (var lstYear in listOfYears)
            {
                timeYears.Add(new SelectListItem { Text = lstYear, Value = lstYear });
            }
            var currentYear = DateTime.Now.Year;

            var listOfPayPeriods = new List<SelectListItem>();
            listOfPayPeriods.Add(new SelectListItem { Text = "03/22/2016-03/28/2016", Value = "1" });
            listOfPayPeriods.Add(new SelectListItem { Text = "03/29/2016-04/15/2016", Value = "2" });
            NM.Web.WebApplication.Timesheets.Models.ViewModel.EmployeeInfoHeaderViewModel model = new Models.ViewModel.EmployeeInfoHeaderViewModel()
            {
                displayYear = currentYear.ToString(),
                FullName = "Cecilia Carter",
                TimeYears = timeYears,
                PayPeriod = listOfPayPeriods
            };

            return PartialView("Header", model);
        }
        #endregion Actions

        #region private methods

        #endregion private methods
    }
}