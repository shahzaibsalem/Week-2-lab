using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            students [] s1 = new students[10];
            string option;
            int count = 0;
            do
            {
                option = choiceMenu();
                Console.Clear();
                if (option == "1")
                {
                    if(count==0)
                    {
                        Console.WriteLine("No record found!!!!");
                    }
                    if(count!=0)
                    {
                        viewStudents(s1, count);
                    }
                    
                }
                else if (option == "2")
                {
                    float r;
                    if(count==0)
                    {
                        Console.WriteLine("No record found!!!!");
                    }
                    else
                    {
                        r = topStudent(s1, count);
                        Console.WriteLine(r);
                    }
                }
                else if (option == "3")
                {
                    if(count==9)
                    {
                        Console.WriteLine("Not enough space!!!!");
                    }
                    else
                    {
                        s1[count] = addStudent();
                        count++;
                    }
                }
                else
                {
                    break;
                }

            } while (option == "1" || option == "2" || option == "3");
            Console.WriteLine("Invalid input!!!!");
            Console.ReadKey();

        }
        static string choiceMenu()
        {
            string option;
            Console.WriteLine("1.See all students!!!!");
            Console.WriteLine("2.See top students!!!");
            Console.WriteLine("3,Add a student!!!!");
            option = Console.ReadLine();
            return option;
        }
        static float topStudent(students[]s1,int count)
        {
            float larger = 0;
                for(int i =0; i <count; i++)
                {
                  if(s1[i].cgpa>larger)
                {
                    larger = s1[i].cgpa;
                }
                }
            return larger;
        }
        static students addStudent()
        {
            Console.Clear();
            students s = new students();
            Console.WriteLine("Enter name!!!!");
            s.name = Console.ReadLine();
            Console.WriteLine("Enter roll number!!!!");
            s.rollNumber = Console.ReadLine();
            Console.WriteLine("Enter CGPA!!!!");
            s.cgpa =float.Parse( Console.ReadLine());
            Console.WriteLine("Is hostellide?!!!!");
            s.isHostelide = Console.ReadLine();
            return s;
        }
        static void viewStudents(students [] s1,int count)
        {
            for(int i =0; i <count; i++)
            {
                Console.WriteLine("NAME:{0},Roll number:{1},CGPA:{2},Hostellide:{3}",s1[i].name,s1[i].rollNumber,s1[i].cgpa,s1[i].isHostelide);
            }
            Console.ReadKey();
        }
    }
}
