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

            double result = theLargest(n1, n2, n3);
            Console.WriteLine("The largest number is : " + result);

        }
        static int theLargest(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
