using System;

namespace Simple_conditional_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current time?");
            int hour = int.Parse(Console.ReadLine());
            if (hour < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good night!");
            }
        }
    }
}
