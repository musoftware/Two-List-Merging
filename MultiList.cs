using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM_Speed_V2.Operations
{
    class MultiList
    {

        public List<string> a1 = new List<string>();
        public List<string> a2 = new List<string>();

        public List<a12Obj> CompleteA2(int countA2eachA1 = 1)
        {
            if (a1.Count == 0) return new List<a12Obj>();
            if (a2.Count == 0) return new List<a12Obj>();
         
            List<a12Obj> list = new List<a12Obj>();
            int a1Index = 0;
            int a1tmp = 0;
            foreach (var item in a2)
            {
                if (a1tmp == countA2eachA1)
                {
                    a1Index++;
                    a1tmp = 1;
                }
                else
                    a1tmp++;
                
                if (a1Index >= a1.Count) a1Index = 0;

                list.Add(new a12Obj() { a1 = a1[a1Index], a2 = item });
            }
            return list;
        }

        public List<a12Obj> SeqA1(int countA2eachA1 = 1)
        {
            if (a1.Count == 0) return new List<a12Obj>();
            if (a2.Count == 0) return new List<a12Obj>();

            List<a12Obj> list = new List<a12Obj>();
            int a2Index = 0;
            foreach (var item in a1)
            {
                if (a2Index >= a2.Count) break;
                for (int i = 0; i < countA2eachA1; i++)
                {
                    if (a2Index >= a2.Count) break;
                    list.Add(new a12Obj() { a1 = item, a2 = a2[a2Index] });
                    a2Index++;
                }
            }
            return list;
        }



    }
}
