using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_02_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat: Írjunk programot, amely egy adott értelmes szövegről eldönti, hogy több szóból áll-e!

            Console.Write("Írjon be egy megvizsgálandó szöveget: ");
            string szoveg1 = Console.ReadLine();

            if (szoveg1.ToLower().Contains(' '))
                Console.WriteLine("A szövegben több szó is szerepel!");
            else
                Console.WriteLine("A szövegben csak egy szó szerepel!");

            // 2. feladat: Határozzuk meg az S karaktersorozatban a magánhangzók számát!

            Console.Write("Írjon be egy megvizsgálandó szöveget: ");
            string szoveg2 = Console.ReadLine().ToLower();

            char[] maganhangzok = "aáeéiíoóöőuúüű".ToCharArray();
            int maganhangzok_szama = 0;

            for (int i = 0; i < szoveg2.Length; i++)
            {
                if (maganhangzok.Contains(szoveg2[i])) {
                    maganhangzok_szama++;
                }
            }

            Console.WriteLine($"A szövegben {maganhangzok_szama} darab magánhangzó van.");

            // 3. feladat: Az inputként beolvasott szövegben cserélje ki az összes szóközt a # karakterre, majd az így kapott szöveget írja ki a képernyőre!

            Console.Write("Írjon be egy megváltoztatandó szöveget: ");
            string szoveg3 = Console.ReadLine();

            Console.WriteLine($"A módosított szöveg: {szoveg3.Replace(" ", "#")}");

            // 4. feladat: Határozzuk meg, hogy egy adott névsorban kiknek kezdődik „B” betűvel a neve!

            string[] nevek = { "András", "Balázs", "Gergely", "László", "Sanyi", "Gábor", "Boldizsár", "Beatrix", "Valter"};
            List<string> b_nevek = new List<string>() {};

            foreach (string b in nevek) 
            {
                if (b[0] == 'B')
                {
                    b_nevek.Add(b);
                }
            }

            Console.Write("A 'B' - vel kezdődő nevek: ");
            b_nevek.ForEach(b => Console.Write($"{b} "));
            Console.WriteLine();

            // 5. feladat: Állapítsa meg, hogy az input szövegben szerepel-e legalább egy szám!
            Console.Write("Írjon be egy megvizsgálandó szöveget: ");
            string szoveg4 = Console.ReadLine().ToLower();

            bool szam_van = szoveg4.Any(char.IsDigit);

            if (szam_van)
                Console.WriteLine("A szövegben van szám!");
            else
                Console.WriteLine("A szövegben nincs szám!");
        }
    }
}
