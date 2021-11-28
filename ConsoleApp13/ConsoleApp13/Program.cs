using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI, wzrost, masa;
            Console.WriteLine("Podaj wzrost (m) ");
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj mase (kg): ");
            masa = double.Parse(Console.ReadLine());
            BMI = masa / (wzrost * 2);
            Console.WriteLine("BMI:{0:F2}", BMI);
            Console.ReadKey();
        }

    }
}