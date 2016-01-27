using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NM.Web.WebApplication.Timesheets.United.Enums
{
    public class Enumeration
    {
        /// <summary>
        /// Defines the possible Time Pay Period for PayPeriod picklist
        /// </summary>
        public enum TimePayPeriod
        {
            Current,
            Next,
            Previous,
            DateRange
        }
    }
}
