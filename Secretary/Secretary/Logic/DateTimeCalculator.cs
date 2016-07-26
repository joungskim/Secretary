using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Secretary.Models;

namespace Secretary.Logic
{
    class DateTimeCalculator
    {
        public TimeSpan CalculateDifference(DateTime In, DateTime Out)
        {
            return Out - In;
        }

        public TimeSpan GetTimeWorkedToday(List<DateTime> allDateTimes)
        {
            var today = allDateTimes.FindAll(x => x == DateTime.Today);
            return new TimeSpan(today.Sum(m => m.Ticks));
        }

        public DateTime GetClockInToday(List<DateTimeModel> allDateTimes)
        {
            try
            {
                var today = allDateTimes.FindAll(x => x.dateTime.Date == DateTime.Now.Date);
                return today.First().dateTime;
            }
            catch
            {
                
            }
            return DateTime.Now;
        }
    }
}
