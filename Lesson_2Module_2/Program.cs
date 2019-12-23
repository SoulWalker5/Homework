using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            var command = new Dictionary<ConsoleKey, IMenu>
            {
                [ConsoleKey.A] = new GetPart(car),
                [ConsoleKey.P] = new PrintInfo(car),
                [ConsoleKey.S] = new GetStatus(car),

            };

            while (true)
            {
                Console.WriteLine("A - Add Part ");
                Console.WriteLine("P - Print Info ");
                Console.WriteLine("S - Status");

                var key = Console.ReadKey().Key;
                Console.WriteLine();
                if (!command.ContainsKey(key))
                    break;

                var selectedCommand = command[key];
                selectedCommand.Action();
            }
        }
    }
}
