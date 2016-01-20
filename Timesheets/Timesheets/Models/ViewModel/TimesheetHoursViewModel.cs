using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NM.Web.WebApplication.Timesheets.Models.ViewModel
{
    public class TimesheetHoursViewModel
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string PayPeriod { get; set; }
        public DateTime Date { get; set; }
        public int TimeStart { get; set; }
        public int TimeEnd { get; set; }
        public decimal Hours { get; set; }
        public string HoursType { get; set; }
        public decimal HoursRegular { get; set; }
        public decimal HoursHoliday { get; set; }
        public decimal HoursPTO { get; set; }
        public decimal HoursJuryDuty { get; set; }
        public decimal HoursBereavement { get; set; }
        public decimal HoursUnpaid { get; set; }
        public decimal HoursVolunteerPTO { get; set; }
        public bool IsOnCall { get; set; }
        public float Mileage { get; set; }
        public string Status { get; set; }
        public DateTime EntryDate { get; set; }
        public string EntryUser { get; set; }
        public DateTime Submitdate { get; set; }
        public string SubmitUser { get; set; }
        public DateTime ApproveDate { get; set; }
        public string ApproveUser { get; set; }
        public DateTime ProcessDate { get; set; }
        public int ProcessPayPeriod { get; set; }
        public bool LockOutEmployee { get; set; }
        public bool LockOutManager { get; set; }
        public bool LockOutAll { get; set; }
        public string eidProcessedPayPeriod { get; set; }
 

    }
}