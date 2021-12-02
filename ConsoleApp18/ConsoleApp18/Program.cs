using System;

namespace ConsoleApp18
{
    class Program
    {
        public const double sr1 = 2.00;
        public const double sr2 = 3.99;
        public const double sr3 = 4.00;
        public const double sr4 = 4.79;
        public const double sr5 = 4.80;
        public const double sr6 = 5.00;
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj srednia:");
            double srednia = Console.ReadLine();
            if (srednia >= sr1 && srednia <= sr2)
            {
                Console.WriteLine("Nic nie przysluguje!");
            }
            else if (srednia >= sr3 && srednia <= sr4)
            {
                Console.WriteLine("Przysluguje: 350,00 zl");
            }
            else if (srednia >= sr5 && srednia <= sr6)
            {
                Console.WriteLine("Przysluguje: 550,00 zl");
            }
            else Console.WriteLine("Srednia podana nie miesci sie w skali");
            Console.ReadKey();
        }
    }

}
