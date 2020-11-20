using System;
using System.Globalization;

namespace entrada_de_dados_no_csharp
{
    class Program
    {
        /*Make a program that: 1) Read an integer
         * 2)Read a character
         * 3)Read a double number.
         * 4)Read a name (single word), gender (F or M character), age (integer) and height (double) on the same line,
         * storing it in four variables with the appropriate types*/
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            char gender = char.Parse(vet[1]);
            int age = int.Parse(vet[2]);
            double height = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("You typed:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(name);
            Console.WriteLine(gender);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}