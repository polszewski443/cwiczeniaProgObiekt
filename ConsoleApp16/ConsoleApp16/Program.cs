using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(" x={0}, y={1}", x, y);
            Console.ReadKey();
        }
    }
}
