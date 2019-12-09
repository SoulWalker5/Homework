using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLforL1_2;

namespace Lesson_1_2
{
    class Gym
    {
        static void Main(string[] args)
        {
            string name;
            int repeats;

            Guy.Start(out name, out repeats);
            var newGuy = new Guy(name, repeats);
            KeeperGuy.guys.Add(newGuy);

            NewGym(name, repeats);
        }
        static void NewGym(string name, int repeats)
        {
            while (true)
            {
                Guy.Menu();
                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            Guy.Cheek(name, repeats);
                            break;
                        }
                    case ConsoleKey.T:
                        {
                            Console.WriteLine("Press any key to train");
                            KeeperGuy.Train();
                            break;
                        }
                    case ConsoleKey.M:
                        {
                            NewGym(name, repeats);
                            break;
                        }
                    case ConsoleKey.P:
                        {
                            KeeperGuy.Print();
                            break;
                        }
                    case ConsoleKey.C:
                        {
                            Console.Clear();
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            return;
                        }
                }
            }
        }

    }
}
