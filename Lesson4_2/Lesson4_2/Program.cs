using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bobr bobr = new Bobr();
            Bobr bobrtwo = new Bobr();
            bobr.Name = "Vasia";
            bobrtwo.Name = "Leha";
            BobrHouse bobrHouse = new BobrHouse();

            object trash = ("Hello World!");
            object trashtwo = ("Vasia Negodiay");

            bobrHouse.AddBobr(bobr);
            bobrHouse.AddBobr(bobrtwo);
            bobrHouse.AddTrash(trash);
            bobrHouse.AddTrash(trashtwo);

            bobrHouse.SetTrashToBobr(trash, bobr);
            bobrHouse.SetTrashToBobr(trashtwo, bobrtwo);
            bobrHouse.SetTrashToBobr(trashtwo, bobr);

        }
    }
}
