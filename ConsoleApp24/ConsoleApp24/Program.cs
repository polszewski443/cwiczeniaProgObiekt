
using System;

namespace ConsoleApp24
{
    class Program
    {
        public static void Main()
        {
            int[] tab = new int[1234];

            Random liczba = new Random();
            for (int i = 0; i < 1234; i++)
            {
                tab[i] = liczba.Next(1, 9999);
            }
            for (int i = 0; i <= tab.Length - 1; i++)
            {
                int licznik = 0;
                for (int j = 1; j <= Math.Sqrt(tab[i]); j++)
                {
                    if (tab[i] % j == 0)
                    {
                        licznik++;
                    }

                }
                if (licznik is 1)
                {
                    Console.WriteLine("{0} to liczba pierwsza.", tab[i]);
                }
                Console.WriteLine("{0} to nie liczba pierwsza.", tab[i]);
            }
        }
    }
}