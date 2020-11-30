using System;

namespace Comparative_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;
            Console.WriteLine("C1: " + c1);
            Console.WriteLine("C2: " + c2);
            Console.WriteLine("C3: " + c3);
            Console.WriteLine("C4: " + c4);
            Console.WriteLine("------------");
            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;
            Console.WriteLine("C5: " + c5);
            Console.WriteLine("C6: " + c6);
            Console.WriteLine("C7: " + c7);
            Console.WriteLine("C8: " + c8);

            /*OUTPUT:
             * C1: False
             * C2: True
             * C3: False
             * C4: True
             * ------------
             * C5: True
             * C6: True
             * C7: True
             * C8: False*/
        }
    }
}
