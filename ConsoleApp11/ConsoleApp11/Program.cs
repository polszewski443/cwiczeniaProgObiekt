using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok a program sprawdzi czy jest przestepny: ");
            int rok = int.Parse(Console.ReadLine());
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                Console.WriteLine("Rok jest przestepny");
            }
            else 
                Console.WriteLine("Rok nie jest przestepny");
            Console.ReadKey();
        }
    }
}
