using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / powierzchnia; 
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();
        }
    }
}
