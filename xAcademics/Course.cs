using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAcademics
{
    internal class Course
    {
        private String _code;
        private String _name;

        public Course(string code, string name)
        {
            _code = code;
            _name = name;
        }

        public string getCode()
        {
            return _code;
        }
        public string getName()
        {
            return _name;
        }     
    }
}


