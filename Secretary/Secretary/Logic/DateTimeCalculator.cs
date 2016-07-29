using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Secretary.Models;

namespace Secretary.Logic
{
    class DateTimeCalculator
    {

        public TimeSpan GetTimeWorkedToday(List<DateTimeModel> allDateTimes, int days)
        {
            if (!allDateTimes.Any()) return new TimeSpan(0, 0, 0, 0);
            var today = GetAllClockInsToday(allDateTimes, days);
            if (today.Count%2 != 0) today.Remove(today.Last());
            var tSpanHours = new TimeSpan(0);
            var temp = new TimeSpan();
            foreach (var item in today)
            {
                if (item.ClockIn)
                {
                    temp = item.dateTime.TimeOfDay;
                }
                else
                {
                    tSpanHours += item.dateTime.TimeOfDay - temp;
                }
            }
            return tSpanHours;
        }

        public List<DateTimeModel> GetAllClockInsToday(List<DateTimeModel> allDateTimes, int dateRange)
        {
            try
            {
                var today = new List<DateTimeModel>();
                var tempToday = DateTime.Now;
                for (var i = 0; i <= dateRange; i++)
                {
                    tempToday = tempToday.Subtract(TimeSpan.FromDays(i));
                    today.AddRange(allDateTimes.FindAll(x => x.dateTime.Date == tempToday.Date));
                }
                return today;
            }
            catch
            {
                // ignored
            }
            return null;
        }

        public DateTime GetFirstClockInToday(List<DateTimeModel> allDateTimes)
        {
            return !allDateTimes.Any() ? allDateTimes.First(x => x.dateTime.Date == DateTime.Now.Date).dateTime : DateTime.MinValue;
        }
    }
}
