using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._09._14_of
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Írjunk programot, amely bekér két egész számot, az alapot és a kitevőt a billentyűzetről és kiírja a hatványt,
             majd ennek a számnak a gyökét 2 tizedes pontossággal!
             2. Kérjük be egy kör sugarát, és írjuk ki a kerületét és a területét 2 tizedes pontossággal!
             3. Kérje be egy kocka oldalának hosszát és számítsa ki a kocka felszínét és térfogatát!
                Az eredményt írja ki 3 tizedes pontossággal a képernyőre!     
             */


            //Fel 1.)
            int alap = 0, kitevo = 0;

            Console.Write("alap:");
            alap = Convert.ToInt32(Console.ReadLine());
            Console.Write("kitevo:");
            kitevo = Convert.ToInt32(Console.ReadLine());

            double hatvany = 0;
            hatvany = Math.Pow(alap,kitevo);

            Console.WriteLine("Hatvany: {0}", hatvany);
            double gyok = 0;
            gyok = Math.Sqrt(hatvany);

            Console.WriteLine("Gyök: {0:0.00}", gyok);
        
            //Fel 2.)

            double sugar = 0, K = 0, T = 0, PI = 3.14, SPOW =0;
            Console.Write("sugar:");
            sugar = Convert.ToDouble(Console.ReadLine());
            K = 2*(sugar * PI);
            SPOW = Math.Pow(sugar,2);
            T = SPOW*PI;
            
            Console.WriteLine("Kerület: {0:0.00}", K);
            Console.WriteLine("Terület: {0:0.00}", T);

            //Fel 3.)

            double oldal = 0, felszin = 0, terfogat = 0;
            Console.Write("Oldal:");
            oldal = Convert.ToDouble(Console.ReadLine());
            terfogat = Math.Pow(oldal,3);
            felszin = 6* Math.Pow(oldal,2);
            Console.WriteLine("Kocka felszíne: {0}", felszin);
            Console.WriteLine("Kocka terfogata: {0}", terfogat);

            



















            Console.ReadKey();
        }
    }
}
