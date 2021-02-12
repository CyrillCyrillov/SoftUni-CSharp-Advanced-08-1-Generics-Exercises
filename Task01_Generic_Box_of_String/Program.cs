using System;

namespace Task01_Generic_Box_of_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lineNimbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lineNimbers; i++)
            {
                Box<string> stringBox = new Box<string>(Console.ReadLine());
                Console.WriteLine(stringBox);
            }
            
        }
    }
}
