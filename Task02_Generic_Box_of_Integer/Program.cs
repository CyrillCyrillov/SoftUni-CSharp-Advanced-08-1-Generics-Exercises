using System;

namespace Task02_Generic_Box_of_Integer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int boxLines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= boxLines; i++)
            {
                Box<int> nextBox = new Box<int>();
                nextBox.Value = int.Parse(Console.ReadLine());

                Console.WriteLine(nextBox);
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
