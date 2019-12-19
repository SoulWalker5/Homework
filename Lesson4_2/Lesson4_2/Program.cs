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
            
            Trash trash = new Trash("Hello World!");
            Trash trashtwo = new Trash("Vasia Negodiay");

            bobrHouse.AddBobr(bobr);
            bobrHouse.AddBobr(bobrtwo);
            bobrHouse.AddTrash(trash);
            bobrHouse.AddTrash(trashtwo);

            DataType dataType = new DataType();

            
            bobrHouse.GetTrash(trash, bobr);

            bobrHouse.GetTrash(trashtwo, bobrtwo);
            bobrHouse.GetTrash(trash, bobr);

            //bobrHouse.SetTrashToBobr(trash);
            
            //Console.WriteLine();
            //Console.ReadKey();
            //bobr.GetTrash(trash);
            //bobrtwo.GetTrash(trash);
            //Console.WriteLine(trash.Owner.Name);
        }
    }
}
