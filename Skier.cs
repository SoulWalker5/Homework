using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLforAll;

namespace TaskSkier
{
    class Skier
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number i:");
            int lowervalue = ReadNumberFromConsole();
            Console.Write("Enter number j:");
            int uppervalue = ReadNumberFromConsole();
            Console.Write("Enter first simple factor:");
            int firstfactor = ReadNumberFromConsole();
            Console.Write("Enter second simple factor:");
            int secondfactor = ReadNumberFromConsole();

            Fizzbuzz.FizzBuzz(lowervalue, uppervalue, firstfactor, secondfactor);
            Console.ReadKey();

            ConsoleKeyInfo key;
            int days = 1;
            do
            {
                Console.WriteLine("\nEnter skier name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the path traveled on the first day");
                double km = ReadNumberFromConsole();
                Console.WriteLine("Enter how much the path increased");
                double percent = ReadNumberFromConsole();
                Console.WriteLine("Enter all the way");
                double allkm = ReadNumberFromConsole();
                Console.WriteLine("Enter the interval between workouts");
                int interval = ReadNumberFromConsole();

                Skiers.Skier(km, allkm, percent, days, interval);

                var newSkier = new Skiers(name, km, percent, allkm, interval);
                SkiersKeeper.Add(newSkier);

                Console.WriteLine("To enter new parameters of skier press Y");
                Console.WriteLine("To print all skiers press P");
                Console.WriteLine("To exit program press any another key");
                key = Console.ReadKey();
            }
            while (key.Key == ConsoleKey.Y);
            {
                if(key.Key == ConsoleKey.P)
                {
                    PrintinfoSkiers();
                }
            }
            Console.ReadKey();
        }
        static int ReadNumberFromConsole()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect number, try again");
            }

            return number;
        }
        static void PrintinfoSkiers()
        {
            foreach(Skiers s in SkiersKeeper.skier)
            {
                Console.WriteLine("\nSkier Name:{0} Way by first day:{1} Growth:{2} All way:{3} Interval:{4}", s.Name, s.Km, s.Percent, s.AllKm, s.Interval);
            }
        }
    }
}
