using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment.Models
{
    class Person
    {
        string name { get; set; }

        public string MyName(string x)
        {
            name = x;
            return name;
        }
    }
}
