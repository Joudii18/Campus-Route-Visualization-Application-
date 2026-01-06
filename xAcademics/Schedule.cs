using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAcademics
{
    internal class Schedule
    {
        private string _days;
        private string _startTime;
        private string _endTime;

        public Schedule(string days, string startTime, string endTime)
        {
            _days = days;
            _startTime = startTime;
            _endTime = endTime;
        }

        public string getDays()
        {
            return _days;
        }

        public string getStartTime()
        {
            return _startTime;
        }

        public string getEndTime()
        {
            return _endTime;
        }

        public override string ToString()
        {
            return "Schedule: " + _days + " from " + _startTime + " to " + _endTime;
        }
    }

}
