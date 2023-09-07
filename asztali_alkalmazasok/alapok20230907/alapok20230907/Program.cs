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

            Console.ReadKey();
        }
    }
}
