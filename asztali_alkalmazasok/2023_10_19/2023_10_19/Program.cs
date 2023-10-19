using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat

            Console.Write("Adja meg az első tetszőleges számot: ");
            int elso_szam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a második tetszőleges számot: ");
            int masodik_szam = Convert.ToInt32(Console.ReadLine());

            int osszeg = 0;

            if (elso_szam > masodik_szam)
                (elso_szam, masodik_szam) = (masodik_szam, elso_szam);

            for (int i = elso_szam; i <= masodik_szam; i++)
            {
                osszeg += i;
            }
            Console.WriteLine(osszeg);


            //Írj egy programot, amely egy adott szám osztóit listázza ki!

            int n = 0;
            Console.Write("Adja meg a számot: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The divisors of {0} are:", n);

            for (int e = 1; e <= n; e++)
            {
                if (n % e == 0)
                {
                    Console.WriteLine(e);
                }
            }


            /*
                              A következő algoritmust kódold le a tanult programozási nyelven:
	                Program tokeletesszam
	                    Be: szam
	                    oszum = 0
	                    Ciklus cv = 1 - től szam DIV 2-ig
	                        Ha szam MOD cv = 0 akkor oszum = oszum + cv
	                        Elágazás vége
	                    Ciklus vége
	                    Ha szam = oszum akkor Ki: A szám tökéletes
	                                                  különben Ki: A szám nem tökéletes
	                    Elágazás vége
	                Program vége
             */

            int r = 0, oszum = 0;

            Console.WriteLine("Adjon meg egy számot: ");
            r = Convert.ToInt32(Console.ReadLine());

            for (int e = 1; e <= r / 2; e++)
            {
                if (r % e == 0)
                {
                    oszum = oszum + e;
                }
            }
            if (r == oszum)
            {
                Console.WriteLine("A szám tökéletes");
            }
            else
            {
                Console.WriteLine("A szám nem tökéletes");
            }


            // ADATSZERKEZETEK
            /*
             1. Vektor (egydimenziós tömb)

            - adott számú, azonos típusú elemet tartalmaz
            - az elemek helyét a sorszám (index) adja meg
            - indexelés 0-tól indul, utolsó sorszám az (elemszám-1)

            -Deklarálás:
            tipus[] tömbneve = new típus[elemszám];
            tipus[] tömbneve = new tipus[]{konkrét elemek felsorolva};

            Pl.:
            int[] egyeszSzamok = new int[30];
            string[] gyumolcsok = new string[]{"alma", "banán", "barack"};
            char[] abc = new char[]{'a', 'b', 'c', 'd'};
             
            - Hivatkozás egy elemre:
            tömbneve[index]
            Pl.: gyumolcsok[1] -> eredmény: banán
             */


            // Feltöltés billentyűzetről
            string[] nevek = new string[3];
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.Write($"{i + 1}. név");
                nevek[i] = Console.ReadLine();
            }


            // Feltöltés véletlen számokkal

            int[] szamok = new int[5];
            Random rand = new Random();

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rand.Next(-50, 51);
            }


            // Tömb bejárása
            // Számlálós ciklussal
            
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine($"{i + 1}. név: {nevek[i]}");
            }


            // Bejárós 

            foreach (string i in nevek)
            {
                Console.WriteLine(i);
            }


            // 2. Mátrix (Kétdimenziós tömb)
            /*
            - adott számú, azonos típusú elemeket tartalmaz
            - az elemek helyét a sorszám (sor index) és az oszlopszám (oszlop index) adja meg
            - indexelés 0-tól indul, utolsó elem indexe a (sorszám - 1, oszlop - 1)

            Deklarálás:
            tipus[,] mátrixneve = new tipus[sorszám,oszlopszám];
            int[,] egeszek = new int[2,3];

            tipus[,] mátrixneve = new tipus[,]{{1. sor elemei},{2. sor elemei}};

            Hivatkozás egy elemre:
            mátrixneve[sorindex, oszlopindex]
            pl.: mátrixneve[0,0] -> első sor első eleme

            pl.:
            char[,] karakterek = new char[,]{{'a', 'b', 'c'},{'d', 'e', 'f'}}
             */


            // Feltöltés billentyűzetről

            double[,] atlagok = new double[2, 3];
            for (int i = 0; i < 2; i++) // i < atlagok.GetLength(0)
            {
                for (int j = 0; j < 3; j++) // j < atlagok.GetLength(1)
                {
                    Console.Write($"{i}. sor {j}. oszlop");
                    atlagok[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }


            // Feltöltés veletlen számmal
            int[,] jegyek = new int[2, 3];
            for (int i = 0; i < jegyek.GetLength(0); i++)
            {
                for (int j = 0; j < jegyek.GetLength(1); j++)
                {
                    jegyek[i, j] = rand.Next(1, 6);
                }
            }


            // Mátrix bejárása
            for (int i = 0; i < jegyek.GetLength(0); i++)
            {
                for (int j = 0; j < jegyek.GetLength(1); j++)
                {
                    Console.Write("{0,5}", jegyek[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
