using System;
using System.Collections.Generic;
using System.Linq;

namespace Task07_Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] comandLineOne = Console.ReadLine().Split(' ').ToArray();

            // name -. comandLineOne[0] + " " + comandLineOne[1]
            // address -> comandLineOne[2]

            string fullName = comandLineOne[0] + " " + comandLineOne[1];
            PersonalTuple<string, string> dataNameAddress = new PersonalTuple<string, string>(fullName, comandLineOne[2]);


            string[] comandLineTwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // name -. comandLineTwo[0]
            // Numbre of beers -> comandLineTwo[1]

            PersonalTuple<string, int> dataNameBeers = new PersonalTuple<string, int>(comandLineTwo[0], int.Parse(comandLineTwo[1]));

            
            string[] comandLineThree = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // numberInt -. comandLineThree[0]
            // numberDouble -> comandLineThree[1]

            PersonalTuple<int, double> dataNumber = new PersonalTuple<int, double>(int.Parse(comandLineThree[0]), double.Parse(comandLineThree[1]));
            
            Console.WriteLine(dataNameAddress);
            Console.WriteLine(dataNameBeers);
            Console.WriteLine(dataNumber);


            ///Console.WriteLine("Hello World!");
        }
    }
}
