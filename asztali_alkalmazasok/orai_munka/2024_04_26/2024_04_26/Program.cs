using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_26
{
    class Matematika
    {
        public double GombTerfogat(double sugar)
        {
            // Számolja ki a gömb térfogatát a megadott sugar alapján.
            double pi = 3.14159265359;
            double terfogat = (4.0 / 3.0) * pi * Math.Pow(sugar, 3);
            return terfogat;
        }

        public double TeglalapTerulet(double a, double b)
        {
            // Számolja ki a téglalap területét a megadott oldalhosszak alapján.
            double terulet = a * b;
            return terulet;
        }

        public double TeglalapKerulete(double a, double b)
        {
            // Számolja ki a téglalap kerületét a megadott oldalhosszak alapján.
            double kerulet = 2 * (a + b);
            return kerulet;
        }

        public Tuple<double, double, double> Hatvanyok(double szam)
        {
            // Számolja ki a megadott szám négyzetét, köbét és negyedik hatványát.
            double negyzet = Math.Pow(szam, 2);
            double kob = Math.Pow(szam, 3);
            double negyedikHatvany = Math.Pow(szam, 4);
            return Tuple.Create(negyzet, kob, negyedikHatvany);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Példányosítás
            Matematika matek = new Matematika();

            // Példa a függvények használatára
            double sugar = 5;
            Console.WriteLine($"A gömb térfogata {matek.GombTerfogat(sugar)} egység.");

            double a = 4;
            double b = 3;
            Console.WriteLine($"A téglalap területe {a}x{b} oldalhossz esetén {matek.TeglalapTerulet(a, b)} egység.");
            Console.WriteLine($"A téglalap kerülete {a}x{b} oldalhossz esetén {matek.TeglalapKerulete(a, b)} egység.");

            double szam = 2;
            var hatvanyok = matek.Hatvanyok(szam);
            Console.WriteLine($"{szam} négyzete: {hatvanyok.Item1}, köbe: {hatvanyok.Item2}, negyedik hatványa: {hatvanyok.Item3}");
        }
    }
}
