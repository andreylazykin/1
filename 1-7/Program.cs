using System;

namespace _7
{
    class Program
    {
        static void Main()
        {
            Console.Write("a=");
            int a = byte.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = byte.Parse(Console.ReadLine());
            int c = a & b;
            Console.WriteLine(Convert.ToString(c, toBase: 2));
            int d = a ^ b;
            Console.WriteLine(Convert.ToString(d, toBase: 2));
            int e = a | b;
            Console.WriteLine(Convert.ToString(e, toBase: 2));
        }
    }
}

