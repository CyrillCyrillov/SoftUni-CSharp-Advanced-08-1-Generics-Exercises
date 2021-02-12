using System;
using System.Collections.Generic;

namespace Task06_Generic_Count_Method_Doubles
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<GenericElement<double>> custumList = new List<GenericElement<double>>();

            int linesNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= linesNumber; i++)
            {
                custumList.Add(new GenericElement<double>(double.Parse(Console.ReadLine())));
            }


            GenericElement<double> toComparison = new GenericElement<double>(double.Parse(Console.ReadLine()));

            Console.WriteLine(CountBiger(custumList, toComparison));
        }

        private static int CountBiger<T>(List<GenericElement<T>> custumList, GenericElement<T> toComparison)
            where T : IComparable
        {
            int count = 0;
            foreach (GenericElement<T> element in custumList)
            {
                if (element.Value.CompareTo(toComparison.Value) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
