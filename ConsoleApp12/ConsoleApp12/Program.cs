using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Podaj liczbe calkowitą a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj liczbe calkowitą b: ");
            b = int.Parse(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("{0} jest dzielnikiem liczby {1}", b, a);
            }
            else
            {
                if (b % a == 0)
                {
                    Console.WriteLine("{0} jest dzielnikiem liczby {1}", a, b);
                }
                else Console.WriteLine("Nie jest dzielnikiem");
            }

        }
    }
}
