using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_2
{
    class Menu : IMenu
    {
        public void Action()
        {
            InternalLogic();
        }

        protected virtual void InternalLogic()
        {
        }
    }
}
