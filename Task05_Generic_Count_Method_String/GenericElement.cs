using System;
using System.Collections.Generic;
using System.Text;

namespace Task05_Generic_Count_Method_String
{
    public class GenericElement<T>
        where T : IComparable
    {

        public GenericElement(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
        /*
        public override string ToString()
        {
            return $"{Value.GetType().FullName.ToString()}: {Value}";
        }
        */
    }
}
