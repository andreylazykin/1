using System;

namespace _2
{
    class Program
    {
        static void Main()
        {
            Console.Write("N=");
            int N = int.Parse(Console.ReadLine());
            string a = "*";
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(a);
                a += "*";
            }
            return;
        }
    }
}

