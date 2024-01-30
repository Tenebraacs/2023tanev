using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._01._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sz = "Szép az idő!";
            Console.WriteLine(sz.Length); //12

            // Első karakter
            Console.WriteLine(sz[0]);

            // Összeadás összefűzés konkatenció

            string a = "alma", b = "fa";

            Console.WriteLine(a + b); //almafa

            //Összehasonlítás
            Console.WriteLine(a[0] > b[0]); //a > b false

            Console.WriteLine((int)a[0]); //97
            Console.WriteLine((int)b[0]); //102

            // Szöveg összehasonlítása: szoveg1.CompareTo(szoveg2)
            int cmp = a.CompareTo(b);

            if (cmp == 0)
            {
                Console.WriteLine("a = b");

            }
            else if (cmp > 0)
            {
                Console.WriteLine("a < b");
            }
            else
            {
                Console.WriteLine("a > b");
            }

            //Levágás
            //TrimStart(), TrimEnd(); Trim()
            string x = "cccalmaccccc";
            //Console.WriteLine(x.TrimStart('c')); Az eleéről töröl.
            //Console.WriteLine(x.TrimEnd('c')); A végéről töröl.
            Console.WriteLine(x.Trim('c')); //Minden honnan törli a c-t

            // Átalakítás - Kisbetű és nagybetű
            Console.WriteLine(sz.ToUpper()); // SZÉP AZ IDŐ!
            Console.WriteLine(sz.ToLower()); // szép az idő!

            // Másolás - Substring kezdő index, másolandó karakterek száma
            Console.WriteLine(sz.Substring(5, 2)); //az
            Console.WriteLine(sz.Substring(5)); //az idő

            // Keresés index of
            // -1 értéket ad vissza, ha a paraméterlistájában a megadott
            // karakter vagy karaktersorozat nem szerepel a stringben
            // 0 vagy pozitív számot ad vissza, ha szerepel -> az a keresett karakter kezdő indexét jelenti
            // az első előfordulás indexét adja vissza

            Console.WriteLine(sz.IndexOf("az")); //5
            Console.WriteLine(sz.IndexOf("b")); //-1
            string sz2 = "azaz";
            Console.WriteLine(sz.IndexOf(sz2)); //-1

            // Csere - Replace(mit, mire)


            Console.ReadKey();
        }
    }
}
