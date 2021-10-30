using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.ReadKey();
            // odpowiedz A x=true y=1 z=2
        }
    }
}
