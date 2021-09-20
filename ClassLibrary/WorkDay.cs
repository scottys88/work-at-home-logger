using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class WorkDay
    {
        public WorkDay(int workDayId)
        {
            WorkDayId = workDayId;
            StartTime = new DateTimeOffset(DateTime.Now);
        }

        public int WorkDayId { get; private set; }

        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
    }
}
