using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment.Models
{
    class Student
    {
        static int studentCount;
        string name;
        public Student(string x)
        {
            name = x;
            studentCount++;
        }
        public string MyName()
        {
            return name;
        }
    }
}
