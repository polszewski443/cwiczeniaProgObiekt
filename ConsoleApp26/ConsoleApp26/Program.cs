using System;

namespace ConsoleApp26
{
    class Program
    {
        public static void Main()
        {
            int[,] tab = new int[,]  {{ 1, 2, 3 , 4, 5},
                                      {6, 7, 8, 9, 20},
                                      {21, 22, 23, 24, 25},
                                      {5, 5, 2, 2, 1},
                                      {3, 2, 3, 2, 3}};
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    Console.Write("{0,3}", tab[a, b]);
                }
                Console.WriteLine();
            }
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        suma = suma + tab[i, j];
                    }
                }
            }
            Console.Write("Suma:{0}", suma);
            Console.ReadKey();
        }
    }
}