using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_InstrukcjaWarunkowa
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchCase();

            Console.Write("Podaj wiek:");
            int wiek = Convert.ToInt32(Console.ReadLine());
            Boolean czyObywatelPolski = true;
            Boolean czyKarany = false;

            /*
             * >= 35 - prezydent
             * >= 30 - senator
             * >= 21 - posel
             * >= 18 - masz prawo glosu
             */

            if (wiek <= 0)
            {
                Console.WriteLine("Podaj poprawny wiek");
                Console.ReadKey();
                return;
            }

            if (czyObywatelPolski)
            {
                // mozna glosowac lub isc do polityki
                if (wiek >= 35 && !czyKarany) // czyKarany==false
                {
                    Console.WriteLine("Może iść na prezydenta");
                }
                else if (wiek >= 30 && !czyKarany)
                {
                    Console.WriteLine("możesz być senatorem");
                }
                else if (wiek >= 21 && !czyKarany)
                {
                    Console.WriteLine("możesz być posłem");
                }
                else if (wiek >= 18)
                {
                    Console.WriteLine("możesz głosować");
                }
                else
                {
                    Console.WriteLine("nie możesz głosować");
                }

            }
            else
            {
                Console.WriteLine("Brak obywatelstwa");
            }

            Console.ReadKey();

        }
    
        static void SwitchCase()
        {
            Console.Write("Podaj ocene od 1 do 6:");
            int ocena = Convert.ToInt32(Console.ReadLine());
            switch (ocena)
            {
                case 1:
                    Console.WriteLine("niedostateczny");
                    break;

                case 2:
                    Console.WriteLine("mierny");
                    break;

                case 3:
                    Console.WriteLine("dostateczny");
                    break;


                default:
                    Console.WriteLine("nie znam");
                    break;
            }
        }
    }
}
