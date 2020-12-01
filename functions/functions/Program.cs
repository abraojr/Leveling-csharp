using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Make a program to read three integers numbers and show the largest one on the screen.*/

            Console.WriteLine("Enter three integers numbers: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("The largest number is: " + n1);
            }
            else if (n2 > n3)
            {
                Console.WriteLine("The largest number is: " + n2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + n3);
            }
        }
    }
}
