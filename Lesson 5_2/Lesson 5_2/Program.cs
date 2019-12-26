using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Admin admin = new Admin();
            Auditoriya auditoriya = new Auditoriya();

            var commands = new Dictionary<ConsoleKey, IMenu>
            {
                [ConsoleKey.Spacebar] = new AddPeople(auditoriya)
            };

            var undone = true;
            while (undone)
            {
                Console.WriteLine("Spacebar - Add human");
                Console.WriteLine("To quit press any another key");

                var key = Console.ReadKey().Key;
                if (!commands.ContainsKey(key))
                    break;
                var command = commands[key];
                Console.Clear();
                command.Action();
                //Console.Clear();
            }

            //Admin admin = new Admin();
            //Teatcher teatcher = new Teatcher();
            //Auditoriya auditoriya = new Auditoriya(admin.SetCapacity());

            //auditoriya.AddPeople();
            //auditoriya.AddPeople();
            //auditoriya.AddPeople();
            //auditoriya.AddPeople();
            //auditoriya.AddPeople();
            //auditoriya.AddPeople();
            //auditoriya.AddPeople();

            //auditoriya.PrintInfo();

        }
    }
}
