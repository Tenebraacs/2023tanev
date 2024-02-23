using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Készítsen programot, amely bekér egy szöveget és kiírja:
                a) A szöveg minden második karakterét!
                b) Minden 5. karakterét!
                c) Hátulról az utolsó 5 karaktert!
                d) A beírt szöveget fordított sorrendben!
             */

            // 1. feladat:

            Console.Write("Írjon be egy szöveget aminek minden második karakterét szeretné kiírni: ");
            string szoveg_1 = Console.ReadLine();

            for (int i = 1; i < szoveg_1.Length; i += 2)
            {
                Console.Write(szoveg_1[i]);
            }
            Console.WriteLine();


            // 2. feladat

            Console.Write("Írjon be egy szöveget aminek minden ötödik karakterét szeretné kiírni: ");
            string szoveg_2 = Console.ReadLine();

            for (int i = 4; i < szoveg_2.Length; i += 5)
            {
                Console.Write(szoveg_2[i]);
            }
            Console.WriteLine();


            // 3. feladat

            Console.Write("Írjon be egy szöveget aminek az utolsó 5 karakterét írja ki: ");
            string szoveg_3 = Console.ReadLine();

            if (szoveg_3.Length >= 5)
            {
                Console.WriteLine(szoveg_3.Substring(szoveg_3.Length - 5));
            }
            else
            {
                Console.WriteLine("Nem tudom ki írni az utolsó 5-öt ha nincs 5 karakter!");
            }


            // 4. feladat

            Console.Write("Írjon be egy szöveget amit meg szeretne fordítani: ");
            string szoveg_4 = Console.ReadLine();


            for (int i = szoveg_4.Length - 1 ; i >= 0; i--)
            {
                Console.Write(szoveg_4[i]);
            }
            Console.WriteLine();


            // 5. feladat

            Console.Write("Írjon be egy szöveget aminek a szavak betűinek sorrendjét meg szeretné fordítani: ");
            string szoveg_5 = Console.ReadLine();

            string[] szavak = szoveg_5.Split(' ');

            foreach (string szo in szavak)
            {
                for (int i = szo.Length - 1; i >= 0; i--)
                {
                    Console.Write(szo[i]);
                }
                Console.Write(' ');
            }
            Console.WriteLine();


            // 6. feladat

            Console.Write("Írjon be egy szöveget amit meg szeretne vizsgálni, hogy van e benne 't': ");
            string szoveg_6 = Console.ReadLine().ToLower();
            bool van_t = false;

            for (int i = 0; i < szoveg_6.Length; i++)
            {
                if (szoveg_6[i] == 't')
                {
                    van_t = true;
                    break;
                }
            }

            if (van_t)
            {
                Console.WriteLine("A szövegben van 't' betű!");
            }
            else
            {
                Console.WriteLine("A szövegben nincs 't' betű!");
            }


            // 7. feladat

            Console.Write("Írjon be egy szöveget amit meg szeretne vizsgálni, hogy benne van e a \"fa\" szó: ");
            string szoveg_7 = Console.ReadLine().ToLower();

            if (szoveg_7.Contains("fa"))
            {
                Console.WriteLine("A szövegben szerepel a \"fa\" szó!");
            }
            else
            {
                Console.WriteLine("A szövegben nem szerepel a \"fa\" szó!");
            }


            // 8. feladat

            Console.Write("Írjon be egy szöveget amit meg szeretne vizsgálni, hogy hány magánhangzó van benne: ");
            string szoveg_8 = Console.ReadLine().ToLower();

            char[] maganhangzok = "aáeéoóöőuúüű".ToCharArray();

            int maganhangzok_szama = 0;

            for (int i = 0; i < szoveg_8.Length; i++)
            {
                if (maganhangzok.Contains(szoveg_8[i]))
                {
                    maganhangzok_szama++;
                }
            }

            Console.WriteLine($"A magánhangzók száma a szövegben: {maganhangzok_szama}");
        }
    }
}
