using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
            //wynik to x = 7 y = 7
        }
    }
}
