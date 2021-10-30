using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //a)
            int x = 1, y = 4, z = 2; 
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0); 
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            //b)
            x = 1;
            y = 4;
            z = 2;
            wynik = (x++ > 1 & y++ == 4 && z-- > 0); 
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            //c)
            x = 1;
            y = 4;
            z = 2; 
            wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            //d)
            x = 1;
            y = 3;
            z = 4; 
            wynik = (x == 1 || y++ > 2 || ++z > 0); 
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            //e)
            x = 1;
            y = 3;
            z = 4; 
            wynik = (x == 1 | y++ > 2 || ++z > 0); 
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            //f)
            x = 1;
            y = 3;
            z = 4;
            wynik = (x == 1 | y++ > 2 | ++z > 0); 
            Console.WriteLine("wynik={0} x={1}  y={2}  z={3}", wynik, x, y, z);
            Console.ReadKey();
            //wynik=False x=2  y=4  z=2
            //wynik = False x = 2  y = 5  z = 2
            //wynik = False x = 2  y = 5  z = 1
            //wynik = True x = 1  y = 3  z = 4
            //wynik = True x = 1  y = 4  z = 4
            //wynik = True x = 1  y = 4  z = 5
        }
    }
}

