using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
