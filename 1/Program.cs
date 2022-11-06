using System;

namespace _1
{
    class Program
    {
        static void Main()
        {
            int c;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((a <= 0) || (b <= 0))
                Console.WriteLine ("Oshibka");
            if ((a > 0) && (b > 0))
                Console.WriteLine(c = a * b);

        }
    }
}
