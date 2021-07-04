using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_PetlaFor
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            for (i = 1; i<=10; i++)
            {
                if (i == 5)
                    continue;

                Console.WriteLine("Licznik petli="+i);

                //i++; uwaga na dmodyfikacje zmiennej iteracyjnej
                if (i == 8) break; //zakonczenie petli
            }

            for (i=50; i>=-10; i-=2)
            {
                Console.WriteLine("Licznik petli=" + i);
            }

            // petla nieskonczona dla for
            for (; ; )
            {
                break;
            }

            string s = "Ala ma kota";
            for (i = 0; i < s.Length; i++)
            {
                //s.Substring(i,1)
                Console.Write(s[i]+",");
            }

            Console.WriteLine();
            foreach (var ch in s)
            {
                Console.Write(ch + ",");
            }



            Console.ReadKey();
        }
    }
}
