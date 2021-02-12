using System;
using System.Collections.Generic;
using System.Text;

namespace Task03_Generic_Swap_Method_Strings
{
    public class GenericElement<T>
    {
        
        public GenericElement(T value)
        {
            Value = value;
        }
        public T Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType().FullName.ToString()}: {Value}";
        }

    }
}
