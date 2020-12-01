using System;
using System.Globalization;

namespace repetitive_structure_while
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Enter a number and show your square root to three decimal places and repeat the procedure.
             * When the user enters a negative number (it may even be the first time), display the message 
             * “Negative number” and exit the program.*/


            Console.Write("Enter a number: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x >= 0.0)
            {
                double squareRoot = Math.Sqrt(x);
                Console.WriteLine(squareRoot.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Enter another number: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Negative number!");
        }
    }
}
