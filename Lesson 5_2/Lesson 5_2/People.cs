using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{
    public abstract class People
    {
        public string Name { get; set; }
    }
    public class Teatcher : People
    {
        public Teatcher()
        {
            Name = "Grigoriy";
        }
    }
    public class Student : People
    {
        public Student()
        {
            Random r = new Random();
            string[] name = { "Vasia", "Vania", "Leha" };
            int index = r.Next(name.Length);
            Name = name[index];
        }
    }
}
