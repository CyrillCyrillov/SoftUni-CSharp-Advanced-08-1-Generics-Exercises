using System;
using System.Collections.Generic;
using System.Text;

namespace Task02_Generic_Box_of_Integer
{
    public class Box<T>
    {
        //private T value;


        public T Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType().FullName.ToString()}: {Value}";
        }

    }
}
