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
            rdemjegy meghatározása

Default (GPT-3.5)

User
Adott egy tetszőleges pont koordinátáival. Határozza meg melyik síknegyedbe esik! A középszintű érettségin maximum 150 pont szerezhető. Kérje be egy tanuló elért pontszámát és írja ki, milyen érdemjegyet kapott, ha a százalékos értékelés a következő: 0-19% - elégtelen, 20-39% - elégséges, 40-59% - közepes, 60-79% - jó, 80-100% - jeles

Old meg C#-ban

ChatGPT
Bizonyára C# nyelven szeretnéd megoldani ezt a feladatot. Az alábbi C# kóddal beolvashatod a tanuló elért pontszámát, majd kiszámíthatod, milyen érdemjegyet kap:

csharp
Copy code
using System;

class Program
{
    static void Main()
    {
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
}
Ez a kód beolvassa a tanuló pontszámát, kiszámítja a százalékos értékelést, majd meghatározza az érdemjegyet az adott tartomány alapján.




User
Adott egy tetszőleges pont koordinátáival. Határozza meg melyik síknegyedbe esik!

Old meg C#BAN

ChatGPT
Az alábbi C# kód segítségével meghatározhatod, hogy egy tetszőleges pont melyik síknegyedbe esik, azaz a pont koordinátái alapján megállapítja, hogy az x és y értékek alapján a pont az első, második, harmadik vagy negyedik síknegyedben van-e.

csharp
Copy code
using System;

class Program
{
    static void Main()
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
        }
    }
}
