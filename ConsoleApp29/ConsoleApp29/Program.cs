using System;


namespace ConsoleApp29
{
    class Program
    {
        static double Zamiana(double a)
        {
            double wynik = (5d / 9) * (a - 32);
            return wynik;
        }
        static void Main(string[] args)
        {
            double fahrenhaity;
            Console.WriteLine("Podaj temperature w stopniach Fahrenheita");
            fahrenhaity = double.Parse(Console.ReadLine());
            Console.WriteLine("Wynik to w stopniach Celsjusza = {0}", Zamiana(fahrenhaity));
            Console.ReadKey();
        }
    }
}