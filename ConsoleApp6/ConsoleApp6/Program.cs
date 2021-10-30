using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
            Console.ReadKey();
            // bedzie miala wartosc 3
        }
    }
}