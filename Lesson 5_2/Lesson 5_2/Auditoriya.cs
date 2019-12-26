using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{

    class Auditoriya
    {
        public Auditoriya()
        {
            Set_capacity();
            humans = new List<Human>();
        }

        public int teacherscount;
        public List<Human> humans;

        public int capacity;

        private void Set_capacity()
        {
            Admin admin = new Admin();
            capacity = admin.SetCapacity();
        }
        public int Get_capacity()
        {
            return capacity;
        }


        public void AddPeople(Human human)
        {

            if (human is Teatcher && humans.Count < capacity)
            {
                if (teacherscount < 1)
                {
                    humans.Add(new Teatcher());
                    teacherscount++;
                }
                else
                    Console.WriteLine("Cannot add more than 1 teatcher"); return;
            }
            if (human is Student && humans.Count < capacity)
            {
                humans.Add(new Student());
            }
            //if (humans.Count == capacity)
            //{
            //    Console.WriteLine("Created new Auditoriya");
            //    new Auditoriya();
            //}
            else
                return;

        }
        public void PrintInfo()
        {
            foreach (var h in humans)
            {
                Console.WriteLine($"{h.Name} , {h.type}");
            }


        }

    }
}
