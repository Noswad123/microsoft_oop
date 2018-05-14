using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment.Models
{
    class Teacher
    {
        string name;
        public Teacher(string x)
        {
            name = x;
        }
        public string MyName()
        {
            return name;
        }
    }
}
