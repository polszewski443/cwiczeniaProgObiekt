using System;

namespace ConsoleApp19b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj l wierszy: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)    
            {
                for (int j = n; j >= i; j--)
                {
                    if (j >= i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}