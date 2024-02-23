using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adja meg a pont x koordinátáját: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem, adja meg a pont y koordinátáját: ");
            double y = Convert.ToDouble(Console.ReadLine());

            string negyed;

            if (x > 0 && y > 0)
                negyed = "I. síknegyed";
            else if (x < 0 && y > 0)
                negyed = "II. síknegyed";
            else if (x < 0 && y < 0)
                negyed = "III. síknegyed";
            else if (x > 0 && y < 0)
                negyed = "IV. síknegyed";
            else if (x == 0 && y == 0)
                negyed = "A pont a koordinátatörzsnél van";
            else
                negyed = "A pont a tengelyeken vagy a tengelyek között van";

            Console.WriteLine($"A pont a(z) {negyed}-ben van.");




            Console.Write("Kérem, adja meg a tanuló elért pontszámát: ");
            int pontszam = Convert.ToInt32(Console.ReadLine());

            double szazalek = (pontszam / 150.0) * 100;

            string erdemjegy;

            if (szazalek >= 0 && szazalek <= 19)
                erdemjegy = "elégtelen";
            else if (szazalek >= 20 && szazalek <= 39)
                erdemjegy = "elégséges";
            else if (szazalek >= 40 && szazalek <= 59)
                erdemjegy = "közepes";
            else if (szazalek >= 60 && szazalek <= 79)
                erdemjegy = "jó";
            else if (szazalek >= 80 && szazalek <= 100)
                erdemjegy = "jeles";
            else
                erdemjegy = "Érvénytelen pontszám";

            Console.WriteLine($"Az érdemjegy: {erdemjegy}");


            //VÉLETLEN SZÁM ELŐÁLLÍTÁSA
            /*
             Random veletlenszam = new Random();

            véletlenszám változó egész szám

            szam = veletlenszam.Next(100) -> [0,99]
            szam = veletlenszam.Next(-50,50) -> [-50,-49]
             */

            //3. feldat
            //két véletlenszerű szám, [0.10], írjuk ki, melyik a nagyobb vay egyenlők e

            Random vsz = new Random();
            int a = 0, b = 0;
            a = vsz.Next(0,11); //Ha nem írunk első számot akkor 0 tól kezdi értelmezni
            b = vsz.Next(0,11);
            Console.WriteLine($"a: {a}, b: {b}");

            if (a > b)
            {
                Console.WriteLine("A nagyobb");
            }
            else if (a < b)
            {
                Console.WriteLine("B nagyobb");
            }
            else
            {
                Console.WriteLine("Egyenlő vagy nem tom.");
            }

            //4. feladat
            int parose = vsz.Next(1, 10);

            if (parose % 2 == 0)
                Console.WriteLine($"A szám '{parose}', páros!");
            else
                Console.WriteLine($"A szám '{parose}', páratlan!");

            //Írjunk programot, amely véletlenszerűen előállít két pontot (koordinátáit), majd kiszámolja azok távolságát.gyök((x1 − x2) × (x1 − x2) +(y2 − y1) × (y2 − y1))

            double x1 = vsz.Next(-10, 10);
            double x2 = vsz.Next(-10, 10);
            double y1 = vsz.Next(-10, 10);
            double y2 = vsz.Next(-10, 10);

            double tavolsag = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);

            Console.WriteLine("Pont 1: ({0}, {1})", x1, y1);
            Console.WriteLine("Pont 2: ({0}, {1})", x2, y2);
            Console.WriteLine("Távolság: {0}", tavolsag);

            //6. feldadat
            Console.Write("Írja be a kezdő számot:");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Írja be a befejező számot:");
            int r2 = Convert.ToInt32(Console.ReadLine());
            if (r1 < r2)
            {
                Console.WriteLine($"A három random szám a megadott tartományban: {vsz.Next(r1, r2)}, {vsz.Next(r1, r2)}, {vsz.Next(r1, r2)}");
            }
            else
            {
                Console.WriteLine($"A három random szám a megadott tartományban: {vsz.Next(r2, r1)}, {vsz.Next(r2, r1)}, {vsz.Next(r2, r1)}");
            }
        }
    }
}
