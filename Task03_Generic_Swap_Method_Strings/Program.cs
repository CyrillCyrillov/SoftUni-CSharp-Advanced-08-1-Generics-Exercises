using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03_Generic_Swap_Method_Strings
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<GenericElement<string>> stringList = new List<GenericElement<string>>();
            
            int linesNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= linesNumber ; i++)
            {
                stringList.Add(new GenericElement<string>(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            // indexOwe -> indexes[0];
            // indexTwo -> indexes[1];

            SwapElements(stringList, indexes[0], indexes[1]);

            foreach (var element in stringList)
            {
                Console.WriteLine(element);
            }
        }

        private static void SwapElements<T>(List<GenericElement<T>> customList, int indexOne, int indexTwo)
        {
            GenericElement<T> helpVar = customList[indexOne];
            customList[indexOne] = customList[indexTwo];
            customList[indexTwo] = helpVar;
        }
    }
}
