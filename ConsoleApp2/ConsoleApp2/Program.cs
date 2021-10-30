using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, delta;
            Console.WriteLine("Podaj a, b oraz c dla rownania kwadratowego ax^2+bx+c=0");
            Console.WriteLine("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            Console.WriteLine("Delta wynosi: {0}", delta);
            Console.ReadKey();
        }
    }
}
