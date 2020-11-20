using System;

namespace assignment_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a /= 2;
            a *= 4;
            Console.WriteLine(a); //OUTPUT: 20
            a *= 4;
            Console.WriteLine(a);  //OUTPUT: 80
            Console.WriteLine("--------------------------------------------");

            int b = 2;
            int c = b++;
            Console.WriteLine(b); //OUTPUT: 3
            Console.WriteLine(c); //OUTPUT: 2
            Console.WriteLine("--------------------------------------------");

            float x = 3.5f;
            float y = 2.5f;
            float z = 4.5f;
            double w = x + y + z;

            Console.WriteLine(w); //OUTPUT: 10.5
            Console.WriteLine("--------------------------------------------");

            int d = 5;
            int e = 2;

            double result = (double)d / e;
            Console.WriteLine(result); //OUTPUT: 2.5
        }
    }
}
