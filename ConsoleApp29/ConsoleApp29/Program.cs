using System;

namespace ConsoleApp29
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Napisz jakies zdanie: ");
            string zdanie = Console.ReadLine();
            int i = 0;
            int ile = 0;
            while (i <= zdanie.Length - 1)
            {
                if (zdanie[i] == ' ' || zdanie[i] == '\t')
                {
                    ile++;
                }
                i++;
            }
            Console.WriteLine("Ilosc wyrazow = " + (ile + 1));
            Console.ReadLine();
        }
    }
}