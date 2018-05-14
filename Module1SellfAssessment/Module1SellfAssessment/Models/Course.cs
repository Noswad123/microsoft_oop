using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment.Models
{
    class Course
    {
        List<Student> students = new List<Student>();
        string name;
        int StudentCount = 0;
        public Course(string title)
        {
            name = title;

        }
        public void AddStudent(Student student)
        {
            students.Add(student);
            StudentCount++;
        }
        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.MyName());
            }
        }
        public string MyName()
        {
            return name;
        }
    }
}
