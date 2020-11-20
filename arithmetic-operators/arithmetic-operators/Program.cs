using System;

namespace operadores_aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {


            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8;

            Console.WriteLine(n1); //OUTPUT: 11
            Console.WriteLine(n2); //OUTPUT: 14             
            Console.WriteLine(n3); //OUTPUT: 2
            Console.WriteLine(n4); //OUTPUT: 1.25
            Console.WriteLine("------------------------------------------------");

            //bhaskara formula
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("The delta is equal: {0}", delta); //OUTPUT: The delta is equal 25
            Console.WriteLine(x1); //OUTPUT: 4
            Console.WriteLine(x2); //OUTPUT: -1
        }
    }
}