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

        public enum TimePeriodType
        {
            Current,
            Next,
            Previous,
            DateRange
        }

        #region Actions
        // GET: NavigationTab
        public ActionResult Nav()
        {
            return PartialView("Nav");
        }

        //public ActionResult Header()
        //{
        //    var listOfYears = repository.GenerateYearsBasedOnCurrentYear(numberOfYearsToGenerateBasedOnCurrentYear).OrderBy(i => i);
        //    var timeYears = new List<SelectListItem>();
        //    foreach (var lstYear in listOfYears)
        //    {
        //        timeYears.Add(new SelectListItem { Text = lstYear, Value = lstYear });
        //    }
        //    var currentYear = DateTime.Now.Year;

        //    var payPeriods = AutoMapper.Mapper.Map(repository.GetCurrentNextPreviousPayPeriod(), new List<Models.ViewModel.PayPeriodViewModel>());

        //    List<SelectListItem> slTimePeriods = new List<SelectListItem>();
        //    foreach (var payperiod in payPeriods)
        //    {
        //        var strPayPeriod = payperiod.dtmPeriodStart + "-" + payperiod.dtmPeriodEnd;
        //        slTimePeriods.Add(new SelectListItem { Text = payperiod.TimePeriod, Value = strPayPeriod.ToString() });
        //    }
        //    if (slTimePeriods.Count() == payPeriods.Count())
        //    {
        //        slTimePeriods.Add(new SelectListItem { Text = "Date Range", Value = TimePeriodType.DateRange.ToString() });
        //    }

        //    Models.ViewModel.YearAndPayPeriodViewModel model = new Models.ViewModel.YearAndPayPeriodViewModel()
        //    {
        //        TimeYears = timeYears,
        //        PayPeriods = null,
        //        CurrentYear = currentYear,
        //        CurrentPayPeriod = payPeriods.FirstOrDefault(i => i.TimePeriod == TimePeriodType.Current.ToString()),
        //        PreviousPayPeriod = payPeriods.FirstOrDefault(i => i.TimePeriod == TimePeriodType.Previous.ToString()),
        //        NextPayPeriod = payPeriods.FirstOrDefault(i => i.TimePeriod == TimePeriodType.Next.ToString()),
        //        TimePeriods = slTimePeriods
        //    };

        //    return PartialView("Header", model);
        //}

        public ActionResult TimesheetHeader()
        {
            //Get the list of Years based on current Year
            var listOfYears = repository.GenerateYearsBasedOnCurrentYear(numberOfYearsToGenerateBasedOnCurrentYear).OrderBy(i => i);
            var timeYears = new List<SelectListItem>();
            foreach (var lstYear in listOfYears)
            {
                timeYears.Add(new SelectListItem { Text = lstYear, Value = lstYear });
            }
            var currentYear = DateTime.Now.Year;

            //Get current, next and previous pay periods
            var payPeriods = AutoMapper.Mapper.Map(repository.GetCurrentNextPreviousPayPeriod(), new List<Models.ViewModel.PayPeriodViewModel>());

            //Get TimePeriod Type
            List<SelectListItem> slTimePeriods = new List<SelectListItem>();
            foreach (var payperiod in payPeriods)
            {
                var strPayPeriod = payperiod.dtmPeriodStart + "-" + payperiod.dtmPeriodEnd;
                slTimePeriods.Add(new SelectListItem { Text = payperiod.TimePeriod, Value = strPayPeriod.ToString() });
            }
            if (slTimePeriods.Count() == payPeriods.Count())
            {
                slTimePeriods.Add(new SelectListItem { Text = "Date Range", Value = "-1" });
            }

            //Populate YearAndPayPeriodViewModel
            Models.ViewModel.YearAndPayPeriodViewModel model = new Models.ViewModel.YearAndPayPeriodViewModel()
            {
                TimeYears = timeYears,
                PayPeriods = payPeriods,
                CurrentYear = currentYear,
                CurrentPayPeriod = payPeriods.FirstOrDefault(i => i.TimePeriod == TimePeriodType.Current.ToString()),
                PreviousPayPeriod = payPeriods.FirstOrDefault(i => i.TimePeriod == TimePeriodType.Previous.ToString()),
                NextPayPeriod = payPeriods.FirstOrDefault(i => i.TimePeriod == TimePeriodType.Next.ToString()),
                TimePeriods = slTimePeriods
            };

            return PartialView("Header", model);
        }

        #endregion Actions

        #region private methods

        #endregion private methods
    }
}