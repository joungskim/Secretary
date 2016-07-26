using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Secretary.Models;

namespace Secretary.Logic
{
    public class CRMLogic
    {
        private List<DateTimeModel> DTModelList;
        private TimeSpan HoursWorkedToday;
        private TimeSpan HoursUntilLeave;
        private DateTimeCalculator DTCalc = new DateTimeCalculator();

        public CRMLogic()
        {
            DTModelList = new List<DateTimeModel>(); //add data file read and update list with time history
            HoursWorkedToday = TimeSpan.Zero;
            HoursUntilLeave = new TimeSpan(0, 8, 0, 0);
            if (HasWorkedToday())
            {
                SetHoursWorkedToday();
            }
        }

        //Gets Date Time String Format
        public string GetDateTimeString(DateTime now)
        {
            return now.ToString("yyyy MMMM dd - hh:mm:ss tt");
        }

        //Creates obj of DateTimeModel and Adds to List
        public string AddTimeList(DateTime cur, bool clockIn)
        {
            DTModelList.Add(new DateTimeModel {ClockIn = clockIn, dateTime = cur});

            return cur.ToString(clockIn ? "yyyy MMMM dd - hh:mm:ss tt [In]" : "yyyy MMMM dd - hh:mm:ss tt [Out]");
        }

        public string GetClockOutTime()
        {
            if (DTModelList == null)
            {
                return "Clock In For Clockout Time";
            }

            return DateTime.Now.Add(HoursUntilLeave).ToString("yyyy MMMM dd - hh:mm:ss tt");
        }

        public string GetHoursRemaining()
        {
            return HoursUntilLeave.ToString();
        }

        public string SubtractHoursUntilLeave()
        {
            HoursUntilLeave = HoursUntilLeave.Subtract(TimeSpan.FromHours(1));
            return HoursUntilLeave.ToString();
        }
        public string AddHoursUntilLeave()
        {
            HoursUntilLeave = HoursUntilLeave.Add(TimeSpan.FromHours(1));
            return HoursUntilLeave.ToString();
        }

        public string SubtractSecondsFromRemainingTime()
        {
            HoursUntilLeave = HoursUntilLeave.Subtract(TimeSpan.FromSeconds(1));
            return HoursUntilLeave.ToString();
        }

        public void SetHoursWorkedToday()
        {
            HoursWorkedToday = DTCalc.GetTimeWorkedToday(DTModelList.Select(x => x.dateTime).ToList());
        }

        public bool HasWorkedToday()
        {
            return DTCalc.GetTimeWorkedToday(DTModelList.Select(x => x.dateTime).ToList()) > TimeSpan.Zero;
        }
    }
}
