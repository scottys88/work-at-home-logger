using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class WorkDayRepository
    {
        public WorkDayRepository()
        {

        }

        public WorkDay Retrieve()
        {
            var workDay = new WorkDay(1);

            return workDay;
        }
    }
}
