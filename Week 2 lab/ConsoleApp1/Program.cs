using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        class students
        {
            public string studentName;
            public string rollNumber;
            public string cgpa;
        }

        static void Main(string[] args)
        {
            students s1 = new students();
            Console.WriteLine("Write name!!!!!");
            s1.studentName = Console.ReadLine();
            Console.WriteLine("Enter roll number!!!!");
            s1.rollNumber = Console.ReadLine();
            Console.WriteLine("Enter CGPA!!!!");
            s1.cgpa = Console.ReadLine();
            Console.WriteLine("Name:{0} , Roll Number:{1} , CGPA:{2}", s1.studentName, s1.rollNumber, s1.cgpa);
            Console.ReadKey();
            students s2 = new students();
            s2.studentName = "Alian";
            s2.rollNumber = "124";
            s2.cgpa = "3.8";
            Console.WriteLine("Name:{0} , Roll Number:{1} , CGPA:{2}", s2.studentName, s2.rollNumber, s2.cgpa);
            Console.ReadKey();
        }
    }
}
