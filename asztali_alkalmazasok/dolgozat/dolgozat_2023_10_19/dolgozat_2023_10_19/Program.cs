using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_2023_10_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat 

            Console.Write("Kérem az első valós számot:");
            double valosszam_1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a második valós számot:");
            double valosszam_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A két valósszám összege: {valosszam_1 + valosszam_2}");

            Console.WriteLine();

            // 2. feladat

            Random rand = new Random();

            int pontszam = rand.Next(0, 100);
            if (pontszam < 0)
                Console.WriteLine("A pontszám nem lehet negatív!");
            else if (pontszam > 100)
                Console.WriteLine("A pontszám magasabb mint a maximális!");
            else
            { 
                if (pontszam < 50)
                Console.WriteLine("Elégtelen osztályzat!");
                else if (pontszam < 65)
                    Console.WriteLine("Elégséges osztályzat!");
                else if (pontszam < 80)
                    Console.WriteLine("Közepes osztályzat!");
                else if (pontszam < 90)
                    Console.WriteLine("Jó osztályzat!");
                else
                    Console.WriteLine("Jeles osztályzat!");
            }

            Console.WriteLine();


            // 3. feladat

            Console.Write("Kérem az 'a' oldal hosszát: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a 'b' oldal hosszát: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a 'c' oldal hosszát: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
                Console.WriteLine("Szerkeszthető háromszög!");
            else
                Console.WriteLine("Nem szerkeszthető háromszög!");

            Console.WriteLine();

            // 4. feladat

            Console.Write("Kérek egy egész számot: ");
            int egesz_szam = Convert.ToInt32(Console.ReadLine());

            if (egesz_szam % 2 == 0)
                Console.WriteLine("Ez egy páros szám!");
            else
                Console.WriteLine("Ez egy páratlan szám!");
        }   
    }
}
