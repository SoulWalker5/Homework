using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{

    class Auditoriya
    {
        public Auditoriya(int capacity)
        {
            teatchers = new List<Teatcher>();
            students = new List<Student>();
            Capacity = capacity;
        }


        public List<Teatcher> teatchers;
        public List<Student> students;

        public int Capacity { get; private set; }

        public void AddPeople()
        {
            Random r = new Random();
            int cheek = r.Next(2);
            if (cheek == 0 && students.Count + teatchers.Count < Capacity && teatchers.Count < 1)
            {
                teatchers.Add(new Teatcher());
            }
            if (cheek == 1 && students.Count + teatchers.Count < Capacity)
            {
                students.Add(new Student());
            }
            else
                return;

        }
    }
}
