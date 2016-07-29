using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            return DTModelList == null ? "Clock In For Clockout Time" : DateTime.Now.Add(HoursUntilLeave).ToString("yyyy MMMM dd - hh:mm:ss tt");
        }

        public string GetHoursRemaining()
        {
            return HoursUntilLeave.ToString();
        }

        public string SubtractHoursUntilLeave()
        {
            if (HoursUntilLeave < TimeSpan.FromHours(1)) return HoursUntilLeave.ToString();
            HoursUntilLeave = HoursUntilLeave.Subtract(TimeSpan.FromHours(1));
            return HoursUntilLeave.ToString();
        }
        public string AddHoursUntilLeave()
        {
            HoursUntilLeave = HoursUntilLeave.Add(TimeSpan.FromHours(1));
            return HoursUntilLeave.ToString();
        }

        public string ClockedHoursByList(int daysAgo)
        {
            return DTCalc.GetTimeWorkedToday(DTModelList, daysAgo).ToString("g");
        }
        public string SubtractSecondsFromRemainingTime()
        {
            if(!(HoursUntilLeave <= TimeSpan.Zero)) HoursUntilLeave = HoursUntilLeave.Subtract(TimeSpan.FromSeconds(1));
            return HoursUntilLeave.ToString();
        }

        public string AddHoursWorkedToday()
        {
            HoursWorkedToday += TimeSpan.FromSeconds(1);
            return HoursWorkedToday.ToString();
        }

        public string GetHoursWorkedToday()
        {
            return HoursWorkedToday.ToString();
        }

    }
}
