using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NM.Web.WebApplication.Timesheets.Models.ViewModel
{
    public class TimesheetViewModel
    {
        public int EmployeeInfoId { get; set; }
        public int MasterUserId { get; set; }
        public List<PayPeriodViewModel> PayPeriod { get; set; }
        public List<SelectListItem> PayPeriodDates { get; set; }
        public List<TSHourEntryViewModel> TimesheetHours { get; set; }
        public bool IsUserNonExempt { get; set; }


    }
}