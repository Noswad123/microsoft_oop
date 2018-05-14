using Module1SellfAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var InformationTechnology = new Uprogram("Information Technology");
            var Bachelor = new Degree("Bachelor");
            InformationTechnology.AddDegree(Bachelor);
            var ProgrammingWithC = new Course("Programming With C#");
            Bachelor.AddCourse(ProgrammingWithC);

            //inside course
            var Jim = new Student("Jim");
            var Nancy = new Student("Nancy");
            var Oscar = new Student("Oscar");
            var Dawson = new Teacher("Mr. Dawson");
            ProgrammingWithC.AddStudent(Jim);
            ProgrammingWithC.AddStudent(Oscar);
            ProgrammingWithC.AddStudent(Nancy);

           

            InformationTechnology.DisplayInfo();
            
            

        }
      

    }
}
