using System;
using System.Collections.Generic;
using System.Linq;
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
}
