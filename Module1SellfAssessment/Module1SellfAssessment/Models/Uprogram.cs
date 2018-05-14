using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1SellfAssessment.Models
{
    class Uprogram
    {
        List<Degree> DegreeList= new List<Degree>();
        string name;
        public Uprogram(string title)
        {
            name = title;
        }
        public void AddDegree(Degree degree)
        {
            DegreeList.Add(degree);
        }
        public void DisplayInfo()
        {
            Console.Write("Name of the program:");
            Console.WriteLine(name);
                   
            Console.Write("Degree:");
            foreach (Degree degree in DegreeList)
            {
                Console.WriteLine(degree.GetName());
                degree.GetInfo();             
            }
            
        }
    }
}
