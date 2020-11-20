using System;
using System.Globalization;

namespace data_output_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char gender = 'M';
            string name = "Abrão";
            double balance = 10.56785;

            Console.WriteLine(gender);
            Console.WriteLine(name);
            Console.WriteLine(balance);
            Console.WriteLine(balance.ToString("F2"));
            Console.WriteLine(balance.ToString("F4"));
            Console.WriteLine(balance.ToString("F4", CultureInfo.InvariantCulture));

            /*OUTPUT:
            M
            Abrão
            10,56785
            10,57
            10,5678
            10.5678 */
        }
    }
}
