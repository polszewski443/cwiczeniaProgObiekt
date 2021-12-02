using System;

namespace ConsoleApp22
{ 
    class Program
    {
        public static void Main()
        {
            int[] a = { 3, -2, -9, 1, 42, -14, -43, -22, 15, 8 };
            int[] b = new int[10];
            int ile = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b[ile] = a[i];
                    ile++;
                }
            }
            Console.Write(string.Join(", ", b));
        }
    }
}