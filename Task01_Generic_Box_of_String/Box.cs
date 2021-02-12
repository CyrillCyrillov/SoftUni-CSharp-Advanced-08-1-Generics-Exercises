using System;
using System.Collections.Generic;
using System.Text;

namespace Task01_Generic_Box_of_String
{
    public class Box<T>
    {
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public override string ToString()
        {
            string valueType = Value.GetType().FullName;
            return $"{valueType}: {Value}";
        }

    }
}
