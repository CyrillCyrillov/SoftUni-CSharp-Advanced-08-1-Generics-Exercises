using System;
using System.Collections.Generic;
using System.Text;

namespace Task07_Tuple
{
    public class PersonalTuple<T1, T2>
    {
        public PersonalTuple(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }


        public T1 Item1 { get;}
        public T2 Item2 { get;}

        public override string ToString()
        {
            string outputFormat = $"{Item1} -> {Item2}";
            return outputFormat;
        }


    }
}
