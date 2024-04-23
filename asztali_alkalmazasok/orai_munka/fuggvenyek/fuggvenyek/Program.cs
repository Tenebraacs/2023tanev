using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace fuggvenyek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. feladat:
            Állítson elő 8 egész számot a [0,100]-ban és írja ki őket egy sorba! Egy függvény segítségével számolja ki a számok átlagát és írja ki 2 tizedes pontossággal!
            */

            Random vsz = new Random();

            int[] szamok = new int[8];
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = vsz.Next(0, 101);
                Console.Write($"{szamok[i]}, ");
            }

            Console.WriteLine($"\nA számok átlaga: {atlagfv(szamok)}");

            /*
            Kérje be egy másodfokú egyenlet együtthatóit, és számolja ki a [-6,6]-ban az egész x értékekhez tartozó függvényértékeket és írja ki a épernyőre egy sorba az x értékeit és alá a megfelelő y értékeket!
            Az együtthatók értéke a [-5,5]-ban legyen! Használjon függvényeket az adatbekéréshez és a függvényérték számításához!
             */

            double a, b, c;
            Console.Write("a = ");
            a = beker();
            Console.Write("b = ");
            b = beker();
            Console.Write("c = ");
            c = beker();

            for (int x = -6; x < 7; x++)
            {
                Console.Write("{0, 5}", x);
            }
            Console.WriteLine();
            for (int x = -6; x < 7; x++)
            {
                Console.Write("{0, 5}", f(a,b,c,x));
            }
        }

        static double atlagfv(int[] a)
        {
            int osszeg = 0;
            for (int i = 0; i < a.Length; i++)
            {
                osszeg += a[i];
            }
            return Convert.ToDouble(osszeg) / a.Length;
        }

        static double beker()
        {
            double adat = 0;
            do
            {
                adat = Convert.ToDouble(Console.ReadLine());
            } while (adat > 5 || adat < -5);

            return adat;
        }

        static double f(double a, double b, double c, double x) 
        {
            double y = 0;
            y = a * x * x + b * x + c;
            return y;
        }
    }
}
