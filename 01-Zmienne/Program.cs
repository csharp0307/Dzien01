using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmienne
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna1 = -10;
            int a = 10, b = 20, c = 30;
            byte wiekUzytkownika = 29; // camelCase
            /*
             Komentarz
            wielolinijkowy
             */
            float cena = 123.45f;
            double zarobki = 123456.78;
            decimal dlugPubliczny = 3666434535345.1234m;

            bool flaga = true; flaga = false;

            Int64 x = 1234;

            char znak = 'a'; znak = '\t';

            String imieNazwisko = "Jan Kowalski";
            imieNazwisko = null;
            imieNazwisko = "";
            //a = null;

            const double pi = 3.14159;
            //pi = -3.14159; stała niemożliwa do zmiany

            StringExamples();

            Console.ReadKey();
        }

        static void StringExamples()
        {
            String lokalizacja1 = "c:\\windows\\system32\\plik.dll";
            String lokalizacja2 = @"c:\windows\system32\plik.dll";
            String slowo1 = "  Ala ma", slowo2 = "kota  ";
            String zdanie = slowo1 + " " + slowo2;
            Console.WriteLine(zdanie);
            Console.WriteLine("Dlugosc zdania to "+zdanie.Length+" znaków");
            Console.WriteLine("Duze litery: "+ zdanie.ToUpper());
            Console.WriteLine("Male litery: "+ zdanie.ToLower());
            Console.WriteLine("Trymowanie: |"+ zdanie.Trim()+"|");
            Console.WriteLine("Zmiana a->*: "+ zdanie.Replace("a","*").Replace("A","*"));
            int x=1, y=2; bool wynik;
            wynik = (x == y);
            wynik = slowo1 == slowo2; // porownuje wskazniki (adresy) do zmiennych
            wynik = zdanie.Trim().Equals("ALA MA KOTA", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("Czy ten sam teskt? "+wynik);
            Console.WriteLine("Pozycja wystąpienia frazy \"ma\" : "+ zdanie.IndexOf("ma"));
            Console.WriteLine("Wytnij pierwsze 5 znakow: "+ zdanie.Substring(0,5));

            zdanie = null;
            //zdanie.Contains("ma");
            Console.WriteLine("Zawartosc zmiennej: "+ zdanie);
            Console.WriteLine("Sprawdz czy string jest null lub pusty: "+ String.IsNullOrEmpty(zdanie) );

        }
    }
}
