using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{
    public class Student : Human
    {
        public Student()
        {
            type = Type.Student;
            string[] name = { "Vasia", "Vania", "Leha" };
            int index = new Random().Next(3);
            Name = name[index];
        }
    }
}
