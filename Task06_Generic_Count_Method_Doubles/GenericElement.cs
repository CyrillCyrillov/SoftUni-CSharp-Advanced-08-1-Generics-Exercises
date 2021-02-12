using System;
using System.Collections.Generic;
using System.Text;

namespace Task06_Generic_Count_Method_Doubles
{
    public class GenericElement<T>
        where T : IComparable
    {

        public GenericElement(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        
    }
}
