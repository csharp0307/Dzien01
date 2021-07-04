using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_KonwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna1 = 10; byte zmienna2 = 5;

            zmienna1 = zmienna2;
            zmienna2 = (byte)zmienna1;
            Console.WriteLine("zmienna1="+zmienna1+", zmienna2="+zmienna2);

            zmienna1 = 257;
            zmienna2 = (byte)zmienna1;
            Console.WriteLine("zmienna1=" + zmienna1 + ", zmienna2=" + zmienna2);

            // 257dec = 00000001 00000001 bin
            // byte   = xxxxxxxx 00000001 
            double wartosc1 = -18765.88;
            int wartosc2 = (int)wartosc1;
            Console.WriteLine("wartosc2="+wartosc2);

            // użycie metod klasy Convert

            wartosc2 = Convert.ToInt32("123");
            Console.WriteLine("wartosc2=" + wartosc2);

            wartosc1 = Convert.ToDouble("123,456");
            Console.WriteLine("wartosc1=" + wartosc1);

            wartosc2 = -10;
            Console.WriteLine(Convert.ToBoolean(wartosc2));
            
            wartosc2 = 0;
            Console.WriteLine(Convert.ToBoolean(wartosc2));
            
            wartosc2 = 1;
            Console.WriteLine(Convert.ToBoolean(wartosc2));
            
            wartosc2 = 10;
            Console.WriteLine(Convert.ToBoolean(wartosc2));

            Console.ReadKey();
        }
    }
}
