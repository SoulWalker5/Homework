using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLforAll;

namespace All_in_One
{
    class KvadratnoeUravnenie
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("a= ");
            a = ReadNumberFromConsole();
            Console.Write("b= ");
            b = ReadNumberFromConsole();
            Console.Write("c= ");
            c = ReadNumberFromConsole();

            Discriminant.discriminant(a, b, c);
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
    }
}
