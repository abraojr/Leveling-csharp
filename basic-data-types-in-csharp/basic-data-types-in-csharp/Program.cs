using System;

namespace basic_data_types_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n1 = -100;
            short n2 = 30000;
            int n3 = -1000000;
            long n4 = 2000000000;
            byte n5 = 254;
            ushort n6 = 60000;
            uint n7 = 10000000;
            ulong n8 = 10;
            float n9 = 4.5f; //sempre ao utilizar float colocar ao lado do numero 'f'
            double n10 = -4.5;
            decimal n11 = -75000;
            char _char = 'A'; //quando usar caracter usar aspas simples ''
            char _char1 = '\u0041'; // usando a tabela unicode
            bool value = true;
            string name = "Abrão Astério Junior";
            object obj1 = "Daniel";
            object obj2 = 9.9f;

            Console.WriteLine("NAME: " + name);
            Console.WriteLine("N1: " + n1);
            Console.WriteLine("N2: " + n2);
            Console.WriteLine("N3: " + n3);
            Console.WriteLine("N4: " + n4);
            Console.WriteLine("N5: " + n5);
            Console.WriteLine("N6: " + n6);
            Console.WriteLine("N7: " + n7);
            Console.WriteLine("N8: " + n8);
            Console.WriteLine("N9: " + n9);
            Console.WriteLine("N10: " + n10);
            Console.WriteLine("N11: " + n11);
            Console.WriteLine("CHAR: " + _char);
            Console.WriteLine("CHAR1: " + _char1);
            Console.WriteLine("VALUE: " + value);
            Console.WriteLine("OBJ1: " + obj1);
            Console.WriteLine("OBJ2: " + obj2);

            Console.ReadKey();

            /*OUTPUT:
             NAME: Abrão Astério Junior
            N1: -100
            N2: 30000
            N3: -1000000
            N4: 2000000000
            N5: 254
            N6: 60000
            N7: 10000000
            N8: 10
            N9: 4,5
            N10: -4,5
            N11: -75000
            CHAR: A
            CHAR1: A
            VALUE: True
            OBJ1: Daniel
            OBJ2: 9,9
                        */
        }
    }
}
