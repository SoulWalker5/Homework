using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class BobrHouse : Bobr
    {
        public BobrHouse()
        {
            bobrs = new List<Bobr>();
            stuffs = new List<Trash>();
            keyValuePairs = new Dictionary<Trash, Bobr>();
        }
        List<Bobr> bobrs;
        List<Trash> stuffs;
        Dictionary<Trash, Bobr> keyValuePairs;

        public void AddBobr(Bobr bobr)
        {
            bobrs.Add(bobr); // or bobrs.Add((Bobr)bobr);
        }
        public void AddTrash(Trash obj)
        {
            stuffs.Add(obj);
        }

        public bool GetTrash(Trash obj, Bobr bobr)
        {
            if (!keyValuePairs.ContainsKey(obj)/*obj.Owner == null || obj.Owner == bobr*/)
            {
                obj.Owner = bobr;
                SetTrashToBobr(obj, bobr);
                return keyValuePairs.TryGetValue(obj, out bobr);
            }
            else
            return keyValuePairs.TryGetValue(obj, out bobr) /*obj.Owner*/;
        }

        public void SetTrashToBobr(Trash obj, Bobr bobr)
        {
            keyValuePairs.Add(obj, bobr);
        }

        //public bool FindOwner(Trash obj)
        //{
        //    if (keyValuePairs.ContainsKey.obj)
        //    {
        //        return true;
        //    }
        //    return false;

        //}
    }
}
