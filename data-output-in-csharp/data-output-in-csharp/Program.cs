using System;
using System.Globalization;

namespace data_output_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 32;
            double balance = 10.56785;
            string name = "Maria";

            Console.WriteLine(name + " is " + age + " years old and has a balance equal to " + balance.ToString("F2", CultureInfo.InvariantCulture) + " Reais");

            /*OUTPUT:
            Maria is 32 years old and has a balance equal to 10.57 Reais */
        }
    }
}
