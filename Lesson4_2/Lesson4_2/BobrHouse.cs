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
            stuffs = new List<object>();
            keyValuePairs = new Dictionary<Bobr, object>();
        }
        List<Bobr> bobrs;
        List<object> stuffs;
        Dictionary<Bobr, object> keyValuePairs;

        public void AddBobr(Bobr bobr)
        {
            bobrs.Add(bobr); // or bobrs.Add((Bobr)bobr);
        }
        public void AddTrash(object obj)
        {
            stuffs.Add(obj);
        }

        //public bool GetTrash(object obj, Bobr bobr)
        //{
        //    if (!keyValuePairs.ContainsKey(obj)/*obj.Owner == null || obj.Owner == bobr*/)
        //    {
        //        obj.Owner = bobr;
        //        SetTrashToBobr(obj, bobr);
        //        return keyValuePairs.TryGetValue(obj, out bobr);
        //    }
        //    else
        //    return keyValuePairs.TryGetValue(obj, out bobr) /*obj.Owner*/;
        //}

        public void SetTrashToBobr(Bobr bobr, object obj)
        {
            if (keyValuePairs.ContainsKey(bobr) || keyValuePairs.Values.Contains(obj))
            {
                return;
            }
            else
            {
                keyValuePairs.Add(bobr, obj);
            }
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
