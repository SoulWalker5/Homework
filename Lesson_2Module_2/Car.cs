using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public readonly List<Part> list = new List<Part>();

        public void GetPart()
        {
            Random random = new Random();
            int part = random.Next(4);
            if (part == 0)
            {
                list.Add(new Part() { Wheel = +1 });
                Console.WriteLine("Added new part wheel");
            }
            if (part == 1)
            {
                list.Add(new Part() { SteeringWheel = +1 });
                Console.WriteLine("Added new part steeringwheel");
            }
            if (part == 2)
            {
                list.Add(new Part() { Engine = +1 });
                Console.WriteLine("Added new part engine");
            }
            if (part == 3)
            {
                list.Add(new Part() { Seat = +1 });
                Console.WriteLine("Added new part seat");
            }
        }
        public void GetStatus()
        {
            int wheel = 0;
            int steeringwheel = 0;
            int engine = 0;
            int seat = 0;
            foreach (var p in list)
            {
                wheel += p.Wheel;
                steeringwheel += p.SteeringWheel;
                engine += p.Engine;
                seat += p.Seat;
                if (wheel >= 4 && steeringwheel >= 1 && engine >= 2 && seat >= 2)
                    Console.WriteLine("Finnaly we got a car!");
                else
                    Console.WriteLine("Not yet!");
            }

        }
        public void PrintInfo()
        {
            foreach (var p in list)
                Console.WriteLine($"Wheel {p.Wheel}, SteeringWheel {p.SteeringWheel}," +
                    $" Engine {p.Engine}, Seat {p.Seat}");
        }

    }
}
