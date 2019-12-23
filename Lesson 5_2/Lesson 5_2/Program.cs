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
            Auditoriya auditoriya = new Auditoriya(admin.SetCapacity());

            auditoriya.AddPeople();
            auditoriya.AddPeople();
            auditoriya.AddPeople();
            auditoriya.AddPeople();
            auditoriya.AddPeople();
            auditoriya.AddPeople();
            auditoriya.AddPeople();
            auditoriya.AddPeople();


        }
    }
}
