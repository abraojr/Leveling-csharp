using System;

namespace implicit_conversion_and_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            float b;
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b); //OUTPUT: 5,1
            Console.WriteLine();

            double c;
            int d;
            c = 5.1;
            d = (int)c;
            Console.WriteLine(d); //OUTPUT: 5
            Console.WriteLine();

            int e = 5;
            int f = 2;
            double result = (double)e / f; //OUTPUT: 2,5
            Console.WriteLine(result);
        }
    }
}
