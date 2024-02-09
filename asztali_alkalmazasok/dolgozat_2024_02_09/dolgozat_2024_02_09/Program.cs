using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat_2024_02_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            // 1. feladat: Kérjen be egy szöveget, és írja ki visszafelé! A fordított szöveg csak kisbetűből álljon!

            Console.Write("1. feladat: Írjon be egy szöveget amit meg szeretne fordítani: ");
            string szoveg1 = Console.ReadLine();
            string forditott_szoveg = "";

            for (int i = szoveg1.Length - 1; i >= 0; i--) 
            { 
                forditott_szoveg += szoveg1[i];
            }

            Console.WriteLine($"A fordított szöveg: {forditott_szoveg}");



            Console.WriteLine();
            // 2. feladat: Írjunk programot, amely egy adott értelmes szövegről eldönti, hogy több szóból áll-e!

            Console.Write("2. feladat: Írjon be egy mondatot amit meg szeretne vizsgálni: ");
            string szoveg2 = Console.ReadLine();

            if (szoveg2.ToLower().Contains(" "))
                Console.WriteLine("A szöveg több szóból áll.");
            else
                Console.WriteLine("A szöveg egy szóból áll.");



            Console.WriteLine();
            // 3. feladat: Kérjen be egy szöveget és cserélje ki az összes szóközt a # karakterre, majd az így kapott szöveget írja ki a képernyőre!

            Console.Write("3. feladat: Írjon be egy mondatot amiben cserét szeretne elvégezni: ");
            string szoveg3 = Console.ReadLine();

            Console.WriteLine($"A kicserélt szöveg: {szoveg3.Replace(" ", "#")}");



            Console.WriteLine();
            // 4. feladat: Kérjen be egy szöveget és egy karaktert, majd írja ki, hogy a szövegben hányszor fordul elő a megadott karakter!

            Console.Write("4. feladat: Írjon be egy mondatot amit meg szeretne vizsgálni: ");
            string szoveg4 = Console.ReadLine();

            Console.Write("Adjon meg egy karaktert amit meg szeretne keresni: ");
            char karakter = Convert.ToChar(Console.ReadLine());
            int karakter_szam = 0;

            for (int i = 0; i < szoveg4.Length; i++)
            {
                if (szoveg4[i] == karakter)
                {
                    karakter_szam++;
                }
            }

            Console.WriteLine($"A szövegben {karakter_szam} alkalommal szerepel a(z) {karakter}");



            Console.WriteLine();
            // 5. feladat: Kérjen be két szöveget a billentyűzetről és írassa ki a képernyőre az ABC-ben előbb levőt, majd alá az ABC-ben hátrébb levőt!

            Console.Write("5. feladat: Írjon be egy mondatot amit meg szeretne vizsgálni: ");
            string szoveg5 = Console.ReadLine();

            Console.Write("Írjon be egy mondatot amit meg szeretne vizsgálni: ");
            string szoveg6 = Console.ReadLine();

            if (szoveg5[0] < szoveg6[0])
            {
                Console.WriteLine(szoveg5);
                Console.WriteLine(szoveg6);
            }
            else
            {
                Console.WriteLine(szoveg6);
                Console.WriteLine(szoveg5);
            }
        }
    }
}
