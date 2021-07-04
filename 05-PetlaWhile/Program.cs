using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_PetlaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 10;
            while (licznik>0)
            {
                // blok petli while
                Console.WriteLine("Licznik="+licznik);
                licznik--;
            }

            licznik = 10;
            do
            {
                // blok petli while
                Console.WriteLine("Licznik=" + licznik);
                licznik--;
            } while (licznik > 0);

            // petla nieskonczona
            while (true)
            {
                Console.Write("Podaj liczbe >100 i podzielna przez 2: ");
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba>100 && liczba%2==0) 
                    break;

            }

            Console.ReadKey();
        }
    }
}
