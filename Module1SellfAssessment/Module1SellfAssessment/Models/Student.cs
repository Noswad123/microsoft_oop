﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment.Models
{
    class Student:Person
    {
        static int studentCount;
        
        public Student()
        {           
            studentCount++;
        }
        
    }
}
