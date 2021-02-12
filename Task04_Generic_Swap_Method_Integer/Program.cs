using System;
using System.Linq;
using System.Collections.Generic;

namespace Task04_Generic_Swap_Method_Integer
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<GenericElement<int>> stringList = new List<GenericElement<int>>();
            
            int linesNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= linesNumber ; i++)
            {
                stringList.Add(new GenericElement<int>(int.Parse(Console.ReadLine())));
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
