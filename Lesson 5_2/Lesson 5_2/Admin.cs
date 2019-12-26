using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{
    public class Admin
    {
        public int SetCapacity()
        {
            Random random = new Random();
            int capacity = random.Next(5, 14);
            return capacity;
        }

    }

    
}
