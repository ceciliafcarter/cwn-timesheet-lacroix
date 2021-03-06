﻿using NM.Web.WebApplication.Timesheets.United.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NM.Web.WebApplication.Timesheets.Controllers
{
    public class TimesheetsController : BaseController
    {
        public TimesheetsController(IRepository repo)
        {
            repository = repo;
        }

        #region Actions
        // GET: Timesheet
        public ActionResult Index()
        {
            if (MasterUser == null) throw new HttpException("Unable to retrieve valid MasterUserId for the current login user.");

            var payPeriods = new List<Models.ViewModel.PayPeriodViewModel>() {
                    new Models.ViewModel.PayPeriodViewModel { PayPeriodID = 1, dtmPeriodDue = (DateTime.Now.Add(TimeSpan.FromDays(1))), dtmPeriodEnd = DateTime.Now.Add(TimeSpan.FromDays(10)), dtmPeriodPayDay = DateTime.Now, dtmPeriodStart = DateTime.Now.Add(TimeSpan.FromDays(1)), dtmProcessed = null, txtStatus = "non-processed" },
                    new Models.ViewModel.PayPeriodViewModel { PayPeriodID = 2, dtmPeriodDue = (DateTime.Now.Add(TimeSpan.FromDays(5))), dtmPeriodEnd = DateTime.Now.Add(TimeSpan.FromDays(20)), dtmPeriodPayDay = DateTime.Now, dtmPeriodStart = DateTime.Now.Add(TimeSpan.FromDays(5)), dtmProcessed = null, txtStatus = "non-processed" },
                    new Models.ViewModel.PayPeriodViewModel { PayPeriodID = 3, dtmPeriodDue = (DateTime.Now.Add(TimeSpan.FromDays(7))), dtmPeriodEnd = DateTime.Now.Add(TimeSpan.FromDays(30)), dtmPeriodPayDay = DateTime.Now, dtmPeriodStart = DateTime.Now.Add(TimeSpan.FromDays(8)), dtmProcessed = null, txtStatus = "non-processed" },
                    new Models.ViewModel.PayPeriodViewModel { PayPeriodID = 4, dtmPeriodDue = (DateTime.Now.Add(TimeSpan.FromDays(1))), dtmPeriodEnd = DateTime.Now.Add(TimeSpan.FromDays(40)), dtmPeriodPayDay = DateTime.Now, dtmPeriodStart = DateTime.Now.Add(TimeSpan.FromDays(13)), dtmProcessed = null, txtStatus = "non-processed" }
                };
            var pp = new List<SelectListItem>();
            foreach (var i in payPeriods)
            {
                var dateString = String.Concat(i.dtmPeriodStart.ToShortDateString() + " - " + i.dtmPeriodEnd.ToShortDateString());
                pp.Add(new SelectListItem { Text = dateString, Value = i.PayPeriodID.ToString() });
            }

            Models.ViewModel.TimesheetViewModel model = new Models.ViewModel.TimesheetViewModel()
            {
                EmployeeInfoId = 1,
                IsUserNonExempt = true,
                MasterUserId = 4997,
                PayPeriodDates = pp,
                PayPeriod = payPeriods,
                YearAndPayPeriod = new Models.ViewModel.YearAndPayPeriodViewModel(),
                TimesheetHours = new List<Models.ViewModel.TSHourEntryViewModel>()
                {
                    new Models.ViewModel.TSHourEntryViewModel { PayPeriod = payPeriods[0], Day="Mon", EntryDate= DateTime.Now.Add(TimeSpan.FromDays(1)).ToShortDateString(), HourType="Regular", StartTime=DateTime.Now.ToShortTimeString(), EndTime=DateTime.Now.ToShortTimeString(), Hours= (decimal)4.50 },
                    new Models.ViewModel.TSHourEntryViewModel { PayPeriod = payPeriods[1], Day="Tue", EntryDate= DateTime.Now.Add(TimeSpan.FromDays(1)).ToShortDateString(), HourType="Regular", StartTime=DateTime.Now.ToShortTimeString(), EndTime=DateTime.Now.ToShortTimeString(), Hours= (decimal)4.50 },
                    new Models.ViewModel.TSHourEntryViewModel { PayPeriod = payPeriods[2], Day="Wed", EntryDate= DateTime.Now.Add(TimeSpan.FromDays(1)).ToShortDateString(), HourType="Regular", StartTime=DateTime.Now.ToShortTimeString(), EndTime=DateTime.Now.ToShortTimeString(), Hours= (decimal)4.50 },
                    new Models.ViewModel.TSHourEntryViewModel { PayPeriod = payPeriods[3], Day="Thu", EntryDate= DateTime.Now.Add(TimeSpan.FromDays(1)).ToShortDateString(), HourType="Regular", StartTime=DateTime.Now.ToShortTimeString(), EndTime=DateTime.Now.ToShortTimeString(), Hours= (decimal)4.50 }
                }
            };
            return View("TimesheetView", model);
        }

        [HttpGet]
        public ActionResult TimesheetHourView()
        {
            Models.ViewModel.TimesheetHoursViewModel TSHours = new Models.ViewModel.TimesheetHoursViewModel()
            {

            };

            return View("TimesheetHours");
        }

        #endregion Actions

    }
}