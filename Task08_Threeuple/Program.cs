using System;
using System.Linq;

namespace Task08_Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] comandLineOne = Console.ReadLine().Split(' ').ToArray();

            // name -> comandLineOne[0] + " " + comandLineOne[1]
            // address -> comandLineOne[2]

            string town = string.Empty; 
            if(comandLineOne.Length > 4)
            {
                
                town = comandLineOne[3] + " " + comandLineOne[4];
            }
            else
            {
                town = comandLineOne[3];
            }


            string fullName = comandLineOne[0] + " " + comandLineOne[1];
            Threeuple<string, string, string> dataNameAddress = new Threeuple<string, string, string>(fullName, comandLineOne[2], town);


            string[] comandLineTwo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // name -> comandLineTwo[0]
            // Numbre of beers -> comandLineTwo[1]

            bool isDrunk = false;
            if(comandLineTwo[2] == "drunk")
            {
                isDrunk = true;
            }

            Threeuple<string, int, bool> dataNameBeers = new Threeuple<string, int, bool>(comandLineTwo[0], int.Parse(comandLineTwo[1]), isDrunk);


            string[] comandLineThree = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            // name -> comandLineThree[0]
            // bak balance -> comandLineThree[1]
            // bak name -> comandLineThree[2]

            Threeuple<string, double, string> dataNumber = new Threeuple<string, Double, string>(comandLineThree[0], double.Parse(comandLineThree[1]), comandLineThree[2]);

            Console.WriteLine(dataNameAddress);
            Console.WriteLine(dataNameBeers);
            Console.WriteLine(dataNumber);

            //Console.WriteLine("Hello World!");
        }
    }
}
