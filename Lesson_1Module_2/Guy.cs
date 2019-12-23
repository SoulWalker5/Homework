using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLforL1_2
{
    public static class KeeperGuy
    {
        public static List<Guy> guys = new List<Guy>();

        public static void Train()
        {
            Console.WriteLine();
            foreach (var g in guys)
            {

                if (g.Repeats == 0)
                {
                    Console.WriteLine("Nobody to train");
                    break;

                }
                else
                {
                    for (int i = g.Repeats; i > 0; i--)
                    {
                        Console.WriteLine($"Name {g.Name}, Repeats {g.Repeats}");
                        Console.ReadKey();
                        g.Repeats--;
                    }
                    Console.WriteLine("{0} end train!", g.Name);
                    Console.WriteLine("Press any key");
                    guys.Add(g);
                    guys.Remove(g);
                    Console.ReadKey();
                    break;
                }
            }

        }
        public static void Print()
        {
            Console.WriteLine();
            foreach (var g in guys)
            {
                Console.WriteLine($"Name {g.Name}, Repeats {g.Repeats}");
            }
        }
    }


    public class Guy
    {
        public Guy(string name, int repeats)
        {
            Name = name;
            Repeats = repeats;
        }

        public string Name { get; set; }
        public int Repeats { get; set; }


        public static int ReadNumberFromConsole()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect number, try again");
            }

            return number;
        }
        public static void Start(out string name, out int repeats)
        {

            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter number of repeats: ");
            repeats = Guy.ReadNumberFromConsole();
        }

        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("Enter - Add new guy ");
            Console.WriteLine("T - Train guys ");
            Console.WriteLine("M - Move to another room ");
            Console.WriteLine("P - Print info ");
            Console.WriteLine("C - Clear screen ");
            Console.WriteLine("Esc - Exit");
            Console.WriteLine();
        }
        public static void Cheek(string name, int repeats)
        {
            Start(out name, out repeats);
            var newGuy = new Guy(name, repeats);
            foreach (var g in KeeperGuy.guys)
            {
                if (g.Repeats == 0)
                {
                    KeeperGuy.guys.Insert(0, newGuy);
                    break;
                }
                else
                {
                    KeeperGuy.guys.Add(newGuy);
                    break;
                }
            }
        }
    }
}
