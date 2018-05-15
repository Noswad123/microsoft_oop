using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment.Models
{
    class Teacher: Person
    {      
       public void GiveTest()
        {
            Console.WriteLine("Test has been given out");
        }
    }
}
