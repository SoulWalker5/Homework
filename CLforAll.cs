using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLforAll
{
    public class Discriminant
    {
        public static void discriminant(int a, int b, int c)
        {


            int d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("No roots d = {0}", d);
            }
            if (d == 0)
            {
                double
                x1 = b / (2 * a);
                Console.WriteLine("d = 0, x = {0}", x1);
            }
            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("d = {0}, x1 = {1},x2 = {2}", d, x1, x2);
                Console.WriteLine("{0}*x^2+({1})*x+({2})={0}*(x-({3}))*(x-({4}))", a, b, c, x1, x2);
            }
        }
    }
    public class Fizzbuzz
    {
        public static void FizzBuzz(int i, int j, int k, int g)
        {
            for (i = 1; i <= j; i++)
            {
                string result = i.ToString();
                if (i % k == 0)
                {
                    result = "Fizz";
                    if (i % g == 0) result = "FizzBuzz";
                }
                else if (i % g == 0) result = "Buzz";
                Console.WriteLine(result);
            }
        }
        
    }
    public static class SkiersKeeper
    {
        public static List<Skiers> skier = new List<Skiers>();

        public static void Add(Skiers newSkier)
        {
            skier.Add(newSkier);
        }
    }
    public class Skiers
    {
        public static void Skier( double km, double allkm, double percent, int days, int interval)
        {
            do
            {
                double kmperdays = ((km / 100) * percent);
                km += kmperdays;
                days = days + interval;
            }
            while (km <= allkm);
            {
                Console.WriteLine("Skier runs {0} km in {1} days", allkm, days);
            }
        }
        public Skiers(string name, double km, double percent, double allkm, int interval)
        {
            Name = name;
            Km = km;
            Percent = percent;
            AllKm = allkm;
            Interval = interval;
        }
        public string Name { get; set; }
        public double Km { get; set; }
        public double Percent { get; set; }
        public double AllKm { get; set; }
        public int Interval { get; set; }
    }

    public static class StudentsKeeper
    {
        public static List<Students> stud = new List<Students>();

        public static void Add(Students newStudent)
        {
            stud.Add(newStudent);
        }
        public static void RemoveAt(int index)
        {
            stud.RemoveAt(index);
        }
    }
    public class Students
    {
        public Students(string firstName, string lastName,
            string course)
        {
            FirstName = firstName;
            LastName = lastName;
            Course = course;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Course { get; set; }
    }
    public class Matrix
    {
        public static void Filling(int n,int[,] array)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(0, 9);
                }
            }
        }
       public static int ReadNumberFromConsole()
       {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter number: ");
            }

            return number;
       }
        public static void PrintAllArray(int[][,] jaggedarrays, int passes)
        {
            for (int i = 0; i < passes; i++)
            {
                if (i > 0)
                {
                    Console.WriteLine();
                }
                for (int j = 0; j < jaggedarrays[i].GetLength(0); j++)
                {
                    for (int k = 0; k < jaggedarrays[i].GetLength(1); k++)
                    {
                        Console.Write("{0}, ", jaggedarrays[i][j, k]);
                    }
                    Console.WriteLine();
                }


            }
        }
        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}, ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void PrintTransArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}, ", array[j, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
