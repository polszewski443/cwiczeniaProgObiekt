using System;

namespace ConsoleApp23
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Podaj n ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[n];
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj wartosc o indexie: {0}", i);
                int wartosc = Convert.ToInt32(Console.ReadLine());
                tab[i] = wartosc;
                suma += tab[i];
            }
            int max = tab[0];
            int indexmax = 0;
            for (int j = 0; j < tab.Length; j++)
            {
                if (tab[j] > max)
                {
                    max = tab[j];
                    indexmax = j;
                }
            }
            int min = tab[0];
            int indexmin = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                    indexmin = i;
                }
            }
            int licznik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > 0)
                {
                    licznik++;
                }
            }
            Console.WriteLine("Max to {0} index {1}", max, indexmax);
            Console.WriteLine("Min to {0} index {1}", min, indexmin);
            Console.WriteLine("Srednia to: {0}", (Convert.ToDouble(suma) / n));
            Console.WriteLine("Dodatnie el ilosc  = {0}", licznik);
        }
    }
}