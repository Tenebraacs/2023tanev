using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alapok20230907
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Egysoros megjegyzés

            /*
             * Több
             * soros
             * megjegyzés
             */


            /*
             * Szintaktikai szabályok:
             * 
             *  - Az utasítások végét pontos vesszővel kell lezárni  ->  ';'
             *  
             *  - A  kis- és nagybetűs írást meg kell különböztetni
             *  
             *  - A program egységeit blokkokba foglaljuk  ->  '{}'
             *  
             *  - Minden zárójelnek van pára
             */


            // Kiíró utasítások

            Console.WriteLine("Első (amúgy nem az) C# programom!");
            Console.Write("Hello World!");
            Console.Write("Szia világ! :)");
            Console.WriteLine();
            // Console.Write(); - üresen nem működik
            Console.Write("\n"); // Ez ugyan azt eredményezi mint a 'Console.WriteLine();'  ->  sortörés


            /*
             * Változók, és típusai:
             * 
             *  - Értékadás (az egyenlőségjel):
             *      - bal oldalán aminek az értékét szeretnénk megadni
             *      - jobb oldalán az érték
             *      
             *  - Változó: 
             *      - Névvel ellátott memóriaszelet
             *      - Módosítható, lekérdezhető
             *      
             *  - Konstans:
             *      - Értéke állandó, lekérdezhető
             *      - Definiálása: 'const'
             *      
             *  - Típus: meghatározzza, hogy a változó milyen halmazból vehet fel és milyen műveletek végezhetőek vele
             *  
             *  - Deklaráció: A váltizó nevének és tíusának meghatározása
             *  
             *  - Kezdőérték: A születéskor hozzárendelt érték
             *  
             *  - Vátozó létrehozásának szintaktikája:
             *  
             *      típus változónév = kezdőértek;
             *      
             *      
             *  Típusok csoportosítása:
             *  
             *   - Egyszerű típusok:
             *      - egész
             *      - valós
             *      - logikai
             *      - karakter
             *      - felsorolás
             *      
             *   - Összetett tíusok:
             *      - szöveg
             *      - vektor/tömb
             *      - rekord (struktúra)
             *      - lista
             *      - verem
             *      - sor
             *      - halmaz
             *      
             *      
             *  Egész számok:
             *  
             *   - byte  ->  0-255
             *   - sbyte  ->  -128 - 127
             *   - short  ->  -32768 - 32767
             *   - ushort  -> 0 - 65535
             *   - int
             *   - uint
             *   - long
             *   - ulong
             *   
             *   - Egész számok műveletei:
             *      - összeadás (+)
             *      - kivonás (-)
             *      - szorzás (*)
             *      - osztás
             *          - mod (maradék) (%)
             *          - div (egészrész) (/)
             *          15 div 2 = 7
             *          15 mod 2 = 1
             */


            // 1. feladat

            int a = 5;
            int b = 3;
            Console.WriteLine("Az első szám: {0}, A második szám: {1}", a, b);


            // 2. feladat

            int szam1 = 4, szam2 = 2;
            Console.WriteLine("szam1 * szam2 = {0}", szam1 * szam2);


            /*
             * Valós számok:
             * 
             *  - float
             *  - double
             *  - decimal
             *  - Műveleteik: +, -, *, / 
             */


            // 3. feladat

            double szam3 = 5.8, szam4 = 2.59;
            Console.WriteLine("szam3 / szam4 = {0:0.00}", szam3 / szam4);


            /*
             * Karakter:
             *  
             *  - deklerálása: 'char'
             */

            char k = 'a';
            char ures = ' ';


            /*
             SZÖVEG: string
            művelete: összefűzés (konkatenáció, +)
            - karakterei egyenként lekérdezhetők, de nem módosíthatók
            - A karakterek sorszámozása 0-tól indul.
             */

            string sz = "almafa";
            Console.WriteLine("Az sz változó első karaktere: {0}", sz[0]);

            /*
             írjuk ki a képernyőre az x*y, majd alá 4 tizedes pontossággal az x/y értékét, ha x=2, y = -11!
             A szoveg változó string típusú legyen és " értéke:" szöveg!
             */

            double x = 2, y = 11;
            string szoveg = " értéke:";

            Console.WriteLine("Az x*y{0} {1}", szoveg, x*y);
            Console.WriteLine("Az x*y{0} {1:0.0000}", szoveg, x/y);

            /*
             LOGIKAI: bool
            Értéke: igaz (ture, 1), hamis (false, 0)
            pl.:
            bool b1 = false;
            bool b2 = 11<3;

            Műveletek: tagadás (!), and (&&), or (||), kizáro vagy (^)

            A   B   A && B  A || B  A ^ B
            i   i      i       i       h
            i   h      h       i       i
            h   i      h       i       i
            h   h      h       h       h
            
            ÁLTALÁNOSSÁGBAN A MŰVELETEKRŐL
            PL.:
            a = a + 3 helyett a += 3
            b = b - 5 helyett b -= 5
            c = c * 2 helyett c *= 2
            d = d / 4 helyett d /= 4
            
            i = i + 1 helyett i++ vagy ++i
            j = j - 1 helyett j-- vagy --j

            Prefexes forma: ++i vagy --j
            - A művelet elvégzésekor a változó eredeti
            értéke egy átmeneti tárolóba másolódik.
             Ezt növeljük (vagy csökkentjük) eggyel, majd az így kapott eredmény a változónak adjuk.
            - Tehát az eredmény és a változó értéke is az új érték lesz.

            int i = 5;
            int x = ++i;
            Eredmény: 6

            int i j = 4;
            int x = ++i;
            Eredmény: 3

            Postfixes forma: i++ vagy j--
            - A művelet elvégzésekor a változó megkapja az úk
            (egggyel növelt/csökkentett) értéket,
            de a művelet eredmény az átmeneti tárolóba tett eredmény lesz

            //BEOLVASÁS BILLENTYŰZETRŐL
            A beolvasás eredményét egy változóban kell eltárolni

            string aszoveg = Console.ReadLine();
             */

            Console.Write("Kérek egy szöveget: ");
            Console.ReadLine();

            Console.Write("egész szám: :");
            int egesz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérek egy valós számot: ");
            double valos = Convert.ToDouble
                (Console.ReadLine());


            /*
             írjunk egy programot ami bekér 2 egész számot és kiíirja összegüket
             */

            int a5 = 0, b5 = 0;
            Console.Write("a =");
            a5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b =");
            b5 = Convert.ToInt32(Console.ReadLine());
            int osszeg = a5 + b5;
            Console.WriteLine("Összeg: {0}", osszeg);

            //MATEMATIKAI FÜGGVÉNYEK
            /*
             - négyzetgyökvonás: Math.Sqrt(szám)
             - hatványozás: Math.Pow(alap,kitevő)
             - kerekítés: Math.Round(szam) --> egész számra
                    Math.Round(szam, tizedesjegyek száma)
             */
            Console.WriteLine("Négyzetgyökvonás {0}", Math.Sqrt(16));
            Console.WriteLine("Hatványozát: {0}", Math.Pow(2, 3));
            Console.WriteLine("Kerekítés: {0}", Math.Round(4.31231231132332));
            Console.WriteLine("Kerekítés: {0}", Math.Round(4.31231231132332,3));


            Console.ReadKey();
        }
    }
}
