using System;

namespace entrada_de_dados_no_csharp
{
    class Program
    {
        /*Make a program that: 1) Read a text until the line breaks and store it in a variable.
         *2) Read three words, one on each line, storing each in a variable.
         * 3) Read three words on the same line, separated by space, storing each one in a variable.*/
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];
            Console.WriteLine("You typed: ");
            Console.WriteLine(phrase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}