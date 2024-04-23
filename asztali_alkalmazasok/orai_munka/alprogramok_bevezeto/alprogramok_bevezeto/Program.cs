using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alprogramok_bevezeto
{
    internal class Program
    {
        static int ev, honap, nap;
        static DateTime szulnap, evvege;
        
        static void Main(string[] args)
        {
            /*
            Alprogramok

            - Az alprogramok részfeladatokat látnak el

            - Általuk az alkalmazás forráskódja olvashatóbb, érthetőbb lesz, hatékonyabban javítható és a későbbiekben kényelmesen tovább is fejlesztheő

            - A program több pontjáról is hivatkozhatunk egy alprogramra, így elég az egyszer megírni. Pl.: véletlenszám előállítás, kiíratás, rendezés, keresés.

            - Bizonyos metódusok az osztályokhoz tartoznak, vagyis objektumok létrehozása nélkül is hívhatók, Osztálynév.Metódus(); formában.
              Ezek a metódusok az ún. statikus (static) tagfüggvények. Pl.: Math.Pow(2, 3)

            - Más metódusokat azonban csak az objektumpéldány létrehozását követően érhetünk el objektumnév.Metódus(); alakban. Szükség esetén az objektumpéldányok egyszerűen elkészíthetők:
              Osztály objektum = new Osztály();
              pl.: Random veletlen = new Random();
                   veletlen.Next();

            - A metódusok definiálása

            módosítók típus metódusnév(paraméterlista)
            {
                //a metódus törzse
                return kifejezés
            }

            - A leggyakrabban előforduló módosítók:

                public - bármely más metódusból hívható
                private - csak és kizárólag osztályon belül érhető el
                static - osztályszinten felhasználható

            - A metódus (visszatérési) típusa az alábbiak közül kerülhet ki:

                egyszerű típusoktól a struktúrákig
                tömb, osztály
                ha nincs visszatérési érték, akkor a void típussal jelezzük

            FÜGGVÉNY

            - A metódus rendelkezik visszatérítési értékkel
            - A metódus a a praméterlistán átadott paraméterekkel műveleteket végez, melyek eredményét egyetlen értékként adja vissza a return utasítás segítségével.

            Pl.:

            static double MertaniKozep(double x, double y)
            {
                return Math.Sqrt(x * y);
            }
            
            ELJÁRÁS
            - Visszatérítési értékkel nem rendelkező metódus.
            - Valamilyen jól meghatározott tevékenység elvégzésére használjuk.

            Pl.:
            static void Kiir()
            {
                int[] szamok = new int[] {2, 5, 8};
                for (int i = 0; i < szamok.Length; i++)
                {
                    Console.Write($"{szamok[i], }");
                }
            }


            Metódus hívása

            - Egy metódus hívásakor a metódus nevét és azt követően kerek zárójelek között az aktuális paraméterek vesszővel tagolt listáját kell megadnunk.

            - Az aktuális paraméterek típusának és számának egyeznie kell a metódus-fejben szereplő megfelelő formális paraméterek típusával és számával.

            Pl.:
            Console.WriteLine($"10 és 1000 mértani közepe: {MertaniKozep(10, 1000)}");
            Kiir();

            Változók használata
            - A metódusokban feklarált változók (lokális változók) csak az őket deklaráló blokk ( utasításblokk) végéig élnek.
            - Amennyiben több metódusból szeretnénk ugyanazt a változót elérni, akkor annak definícióját az osztályon belül, azonban metódusokon kívül kell elhelyeznünk
            - Az ilyen változók az osztályszintű változók (globális változól)
            - Az osztályszintű változók statikussá (static) tehetők, így az osztály oéldányai megosztva használják azt.
            */


            /*
            Feladat:
            Kérjük be a legközelebbi születésnap dátumát (év, hó, nap), majd írjuk k, hogy hány nap van még a születésnapig és az év év végéig!
            Használjunk eljárásokat az adatbekéréshez és a kiíráshoz!
            */

            Console.WriteLine("Kérem a legközelebbi születésnap adatait!");
            adatbekeres();

            szulnap = new DateTime(ev, honap, nap);

            kiirás();
        }

        static void adatbekeres()
        {
            Console.Write("év = ");
            ev = Convert.ToInt32(Console.ReadLine());

            Console.Write("hónap = ");
            honap = Convert.ToInt32(Console.ReadLine());

            Console.Write("nap = ");
            nap = Convert.ToInt32(Console.ReadLine());
        }

        static void kiirás()
        {
            DateTime maidatum = DateTime.Now;
            evvege = new DateTime(2024, 12, 21);

            Console.WriteLine($"A mai dátum: {maidatum}");

            Console.WriteLine($"Év végéig {evvege.Subtract(maidatum).Days} nap van hátra.");

            Console.WriteLine($"A következő születésnapig {szulnap.Subtract(maidatum).Days} nap van hátra.");
        }
    }
}
