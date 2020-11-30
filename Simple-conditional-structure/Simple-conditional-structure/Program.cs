using System;

namespace Simple_conditional_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Pair!");
            }
            else
            {
                Console.WriteLine("Odd!");

            }
        }
    }
}
