using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            //OperatoryArytmetyczne();
            //OperatoryRelacyjne();
            //OperatoryPrzypisania();
            OperatoryLogiczne();

            // przypadek dzielenia
            Console.WriteLine(10/(double)3);

            Console.ReadKey();
        }

        private static void OperatoryLogiczne()
        {
            bool a = false, b = true, c;
            c = a && b; // koniunkcja - iloczyn logiczny
            c = a || b; // alternatywa - suma logiczna
            c = !a; // negacja a - true
            c = !(!a); // podwojna negacja
        }

        private static void OperatoryPrzypisania()
        {
            Int64 a = 35345345345, b = 12312367867867, c;
            c = a;
            c += a; // c = c + a;
            c -= a; // c = c - a;
            c *= a; // c = c * a;
            c /= a; // c = c / a;
            c %= a; // c = c % a;
        }

        private static void OperatoryRelacyjne()
        {
            double x = -8765, y = 1234567.89;
            Console.WriteLine("x="+x+" y="+y);
            Console.WriteLine( x == y ); // rowne
            Console.WriteLine( x != y ); //rozne od
            Console.WriteLine( x > y ); 
            Console.WriteLine( x >= y ); 
            Console.WriteLine( x < y ); 
            Console.WriteLine( x <= y ); 
        }

        private static void OperatoryArytmetyczne()
        {
            double x = -10.345, y = 543.21;
            double z;
            z = x + y;
            z = x - y;
            z = x * y;
            z = x / y;
            z = x % y; // 10 % 3 = 1

            int a = 10;
            a++; // a = a + 1;
            a--; // a = a - 1;

            a++; // przyrostkowy
            ++a; // przedrostkowy

            a = 10;
            Console.WriteLine(++a);
        }
    }
}
