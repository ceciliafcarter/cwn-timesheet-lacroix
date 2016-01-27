using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NM.Web.WebApplication.Timesheets.United.Models;

namespace NM.Web.WebApplication.Timesheets.United.Abstract
{
    public interface IRepository
    {
        void SaveChanges();
        tblMasterUser GetMasterUser();
        tblMasterUser GetMasterUser(string userName);
        List<string> GenerateYearsBasedOnCurrentYear(int numberOfYears);
        List<United.BusinessModel.TimePayPeriod> GetCurrentNextPreviousPayPeriod();
    }
}
