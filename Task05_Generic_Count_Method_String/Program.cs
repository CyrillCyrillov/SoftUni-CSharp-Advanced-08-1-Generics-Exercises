using System;
using System.Collections.Generic;
using System.Linq;

namespace Task05_Generic_Count_Method_String
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<GenericElement<string>> custumList = new List<GenericElement<string>>();

            int linesNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= linesNumber; i++)
            {
                custumList.Add(new GenericElement<string>(Console.ReadLine()));
            }

            string toComparison = Console.ReadLine();

            Console.WriteLine(CountBiger(custumList, toComparison));

            
        }

        private static int CountBiger<T>(List<GenericElement<T>> custumList, string toComparison)
            where T : IComparable
        {
            int count = 0;
            foreach (GenericElement<T> element in custumList)
            {
                if(element.Value.CompareTo(toComparison) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

