using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat
            // Kérjen be egy számot és írja ki a köbgyökét 4 tizedes pontossággal!
            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            double kobgyok = Math.Round(Math.Pow(szam, 1 / 3.0), 4);
            Console.WriteLine($"A szám köbgyöke: {kobgyok}\n");

            // 2. feladat
            // Egy pénztáros a napi bevételének 5%-át megkapja jutalomként. Kérje be a napi bevételt, és írja a képernyőre mennyi a jutalom! A jutalmat kerekítse egész értékre!

            Console.Write("Kérem a napi bevételt: ");
            int bevetel = Convert.ToInt32(Console.ReadLine());
            double jutalom = Math.Round(bevetel * 5 / 100.0);
            Console.WriteLine($"A jutalom {jutalom} Ft\n");

            // 3. feladat
            // Adott egy derékszögű háromszög 2 befogója. Határozza meg ennek ismeretében az átfogót!

            Console.Write("Kérem az 'a' oldal méretét: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a 'b' oldal méretét: ");
            double B = Convert.ToDouble(Console.ReadLine());
            
            double C = Math.Round(Math.Sqrt(A * A + B * B), 2);
            Console.WriteLine($"A 'c' oldal hossza: {C} cm\n");




            // Vezérlési szerkezetek

            /*
             
            1. szekvencia
            2. elágazás
            3. ciklus
             
            */


            // ELÁGAZÁS

            /*
            
            Fajtái:



                - egyszerű/egyirányú
                
                  Ha (logikai kifejezés / feltétel) akkor utasítás(ok)

                    if (logikai kifejezés / feltétel)
                    {
                        utasítás(ok);
                    }



                - Kétirányú

                 Ha (logikai kifejezés / feltétel) akkor utasítás(ok)1
                                                   különben utasítás(ok)2

                    if (logikai kifejezés / feltétel)
                    {
                        utasítás(ok)1;
                    }
                    else
                    {
                        utasítás(ok)2;
                    }



                - Többirányú
                 
                 Ha (logikai kifejezés / feltétel) akkor utasítás(ok)1
                 különben Ha (logikai kifejezés2 / feltétel2) akkor utasítás(ok)2
                    különben Ha (logikai kifejezés3 / feltétel3) akkor utasítás(ok)3
                 ......
                 különben utasítás(ok)N

                    if (logikai kifejezés1 / feltétel1)
                    {
                        utasítás(ok)1;
                    }
                    else if (logikai kifejezés2 / feltétel2)
                    {
                        utasítás(ok)2;
                    }
                    else if (logikai kifejezés3 / feltétel3)
                    {
                        utasítás(ok)3;
                    }
                    ...
                    else
                    {
                        utasítás(ok)N;
                    }

            */


            // 4. feladat
            // Kérjünk be egy egész számot a billentyűzetről, és ha a szám nagyobb mint 0, akkor írjuk ki a képernyőre, hogy "A szám pozitív!"!

            int nagyobb = 0;
            Console.Write("Kérek egy számot: ");
            nagyobb = Convert.ToInt32(Console.ReadLine());

            if (nagyobb > 0)
            {
                Console.WriteLine("A szám pozitív!");
            }


            /*
            Console.Write("Kérem adja meg az 'a' együtthatót: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem adja meg a 'b' együtthatót: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Kérem adja meg a 'c' együtthatót: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double diszkriminans = Math.Pow(b, 2) - 4 * a * c;

            if (diszkriminans < 0)
            {
                Console.WriteLine("Nincs megoldás!");
            }
            else
            {

                double gyok1 = (-b + Math.Sqrt(diszkriminans)) / (2 * a);
                double gyok2 = (-b - Math.Sqrt(diszkriminans)) / (2 * a);

                Console.WriteLine($"Az első gyök: {gyok1:0.00}");
                Console.WriteLine($"A második gyök: {gyok2:0.00}");
            }
            */


            Console.WriteLine("Kérem, adja meg a három számot a háromszög oldalaihoz:");

            Console.Write("Első oldal hossza: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Második oldal hossza: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Harmadik oldal hossza: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Ezek a számok alkothatnak egy háromszögöt.");
            }
            else
            {
                Console.WriteLine("Ezek a számok nem alkothatnak egy háromszögöt.");
            }


            Console.Write("Kérem, adjon meg egy számot: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber % 3 == 0)
            {
                Console.WriteLine($"{inputNumber} osztható maradék nélkül 3-mal.");
            }
            else
            {
                Console.WriteLine($"{inputNumber} nem osztható maradék nélkül 3-mal.");
            }

        }
    }
}
