using System;

namespace repetitive_structure_for
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Enter an N number and then N integer values. Show the sum of the N values entered.*/


            Console.Write("How many integer numbers are you going to type? ");
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Value #{0}: ", i);
                int value = int.Parse(Console.ReadLine());
                sum += value;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}
