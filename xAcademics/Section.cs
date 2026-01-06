using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAcademics
{
    internal class Section
    {
        private string _crn;
        private string _sectionNumber;
        private Course _course;
        private Schedule _schedule;
        private Building _building;

        public Section(string crn, string sectionNumber, Course course, Schedule schedule, Building building)
        {
            _crn = crn;
            _sectionNumber = sectionNumber;
            _course = course;
            _schedule = schedule;
            _building = building;
        }

        public string getCRN()
        {
            return _crn;
        }

        public string getSectionNumber()
        {
            return _sectionNumber;
        }

        public Course getCourse()
        {
            return _course;
        }

        public Schedule getSchedule()
        {
            return _schedule;
        }

        public Building getBuilding()
        {
            return _building;
        }

       
    }
}
