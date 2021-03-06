﻿using NM.Web.WebApplication.Timesheets.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NM.Web.WebApplication.Timesheets.Models.ViewModel
{
    public class PayPeriodViewModel : IMapFrom<United.BusinessModel.TimePayPeriod>
    {
        public int PayPeriodID { get; set; }
        public DateTime dtmPeriodDue { get; set; }
        public DateTime dtmPeriodEnd { get; set; }
        public DateTime dtmPeriodStart { get; set; }
        public DateTime dtmPeriodPayDay { get; set; }
        public string txtStatus { get; set; }
        public DateTime? dtmProcessed { get; set; }
        public string txtLastPeriodOfYear { get; set; }
        public bool IsBiWeeklyPayroll { get; set; }
        public string TimePeriod { get; set; }
    }
}