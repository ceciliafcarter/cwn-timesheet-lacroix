using NM.Web.WebApplication.Timesheets.United.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NM.Web.WebApplication.Timesheets.United.Models;

namespace NM.Web.WebApplication.Timesheets.United.Concrete
{
    public class Repository : IRepository
    {
        private UnitedEntities _db;

        public UnitedEntities db
        {
            get { return _db ?? (db = new UnitedEntities()); }
            set { _db = value; }
        }
        public tblMasterUser GetMasterUser()
        {
            throw new NotImplementedException();
        }

        public tblMasterUser GetMasterUser(string userName)
        {
            var currentUserName = userName.Split(new string[] { "\\" }, StringSplitOptions.None)[1];
            using (var db = new UnitedEntities())
            {
                return db.tblMasterUsers.FirstOrDefault(i => i.UserName == currentUserName);
            }
        }
        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public List<string> GenerateYearsBasedOnCurrentYear(int numberOfYears = 10)
        {
            List<string> stringYears = new List<string>();
            var currentYear = DateTime.Now.Year;
            stringYears.Add(currentYear.ToString());
            
            //set default to 10; display 5 each on future and previous years
            numberOfYears = numberOfYears > 0 ? numberOfYears : 10;
            
            //if number is odd, add one to make it even
            var numberToLoop = (numberOfYears % 2 == 0 ? numberOfYears : numberOfYears + 1) / 2;
                       
            for (int i = 0; i < numberToLoop;)
            {
                //Add future year 
                i++;
                stringYears.Add((currentYear + i).ToString());
                //Add previous year
                stringYears.Add((currentYear - i).ToString());
            }
            return stringYears.ToList();           
        }
    }
}
