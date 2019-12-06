using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLforAll;

namespace ListofStudents
{
    class ProgStudents
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string course;
            ConsoleKeyInfo key;
            do
            {
                Start(out firstName, out lastName, out course, out key);
            }

            while (key.Key == ConsoleKey.Y);
            {
                if(key.Key == ConsoleKey.P)
                {
                    PrintInfo();
                    Console.ReadKey();
                }
            }
        }
        static void PrintInfo()
        {
            foreach (Students s in StudentsKeeper.stud)
            {
                Console.WriteLine("\nFirst Name:{0}  Last Name:{1}  Course:{2}", s.FirstName, s.LastName, s.Course);

            }
        }

        static void Start(out string firstName, out string lastName, out string course, out ConsoleKeyInfo key)
        {
            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter course:");
            course = Console.ReadLine();
            var newStudent = new Students(firstName, lastName, course);
            StudentsKeeper.Add(newStudent);
            Console.WriteLine("\nNew student: First Name:{0}  Last Name:{1}  Course:{2}", firstName, lastName, course);
            Console.WriteLine("\n");
            Console.WriteLine("To continue enter student press Y");
            Console.WriteLine("To print all students press P");
            Console.WriteLine("To exit press any another key");
            key = Console.ReadKey();
            Console.WriteLine("\n");
        }
    }
}
