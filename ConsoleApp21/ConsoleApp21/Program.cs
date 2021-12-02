using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] tab = new int[rozmiar];

            for (int i = 0; i < rozmiar; i++)
            {
                Console.WriteLine("Podaj wartosc {0}", i + 1);
                int wartosc = Convert.ToInt32(Console.ReadLine());
                tab[i] = wartosc;
            }
            for (int j = 0; j < tab.Length; j++)
            {
                Console.WriteLine("Index: {0} Wart: {1}", j + 1, tab[j]);
            }

        }
    }
}