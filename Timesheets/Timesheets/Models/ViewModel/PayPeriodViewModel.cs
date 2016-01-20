using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NM.Web.WebApplication.Timesheets.Models.ViewModel
{
    public class PayPeriodViewModel
    {
        public string PayPeriodId { get; set; }
        public DateTime dtmPeriodDue { get; set; }
        public DateTime dtmPeriodEnd { get; set; }
        public DateTime dtmPeriondStart { get; set; }
        public DateTime dtmPeriodPayDay { get; set; }
        public string txtStatus { get; set; }
        public DateTime? dtmProcessed { get; set; }

        public List<string> TimePeriodType { get; set; }
    }
}