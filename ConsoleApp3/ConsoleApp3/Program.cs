using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double wzrost, masa, BMI;
            Console.WriteLine("Podaj wzrost w metrach i mase w kilogramach, aby program mogl obliczyc wskaznik BMI.");
            Console.WriteLine("Wzrost: ");
            wzrost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masa: ");
            masa = Convert.ToDouble(Console.ReadLine());
            BMI = masa / wzrost;
            Console.WriteLine(wzrost);
            Console.WriteLine("BMI wynosi: {0}", BMI);
            Console.ReadKey();
        }
    }
}
