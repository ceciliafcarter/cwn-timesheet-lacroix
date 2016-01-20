using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NM.Web.WebApplication.Timesheets.Models.ViewModel
{
    public class TSHourEntryViewModel
    {
        public int EmployeeInfoId { get; set; }
        public PayPeriodViewModel PayPeriod { get; set; }
        public string Day { get; set; }
        public string EntryDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public decimal Hours { get; set; }
        public string HourType { get; set; }

        public string Status { get; set; }

    }

    public class TSHourTypeViewModel
    {
        public int HourTypeID { get; set; }
        public string HourType { get; set; }

    }
}