using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment.Models
{
    class Degree
    {
        string name;
        List<Course> courses = new List<Course>();
        public Degree(string title)
        {
            name = title;
        }
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public string GetName()
        {
            return name;
        }
        public void GetInfo()
        {
            foreach(Course course in courses)
            { 
                Console.WriteLine(course.MyName());

                Console.WriteLine($"Student Roster {course.StudentCount}");
                course.DisplayStudents();
            }
        }
    }
}
