using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szemely_azonosito
{
    internal class Program
    {
        static string DatumElemzes(string datum)
        {
            char[] nem_azonosito = { '1', '2', '3', '4' };
            int ev = Convert.ToInt32(datum.Substring(1, 2));
            int ev_most = DateTime.Now.Year - 2000;
            while (true)
            {
                if (nem_azonosito.Contains(datum[0]) && datum.Length == 7 && ((ev >= 97 && (datum[0] == '1' || datum[0] == '2')) || (ev <= ev_most && (datum[0] == '3' || datum[0] == '4'))))
                {
                    if (ev >= 97 && datum[0] == '1' || datum[0] == '2')
                    {
                        datum = "19" + ev.ToString() + datum.Substring(3, 4);
                        return datum;
                    }
                    else
                    {
                        datum = "20" + ev.ToString() + datum.Substring(3, 4);
                        return datum;
                    }
                }
                else
                {
                    Console.WriteLine("Nem megfelelő formátumban adta meg az azonosítót! (nem kezelt; hossz)\n");
                    Console.Write("Írja be a személyazonosító jel első 7 számát:");
                    datum = Console.ReadLine();
                }
            }
        }
        static string[] AzonositoElemzes(string azonosito)
        {
            while (true)
            {
                if (azonosito.Length == 10)
                {
                    string[] tomb = new string[4];
                    tomb[0] = azonosito.Substring(0, 1);
                    tomb[1] = DatumElemzes(azonosito.Substring(0, 7));
                    tomb[2] = azonosito.Substring(7, 3);
                    return tomb;
                }
                else
                {
                    Console.WriteLine("Nem megfelelő formátumban adta meg az azonosítót! (hossz)\n");
                    Console.Write("Írja be a személyazonosító jel első 10 számát:");
                    azonosito = Console.ReadLine();
                }
            }
        }

        static void Main(string[] args)
        {
            // 1. feladat
            Console.Write("Írja be a személyazonosító jel első 10 számát:");
            string beker1 = Console.ReadLine();

            string[] azonosito1 = AzonositoElemzes(beker1);

            // 2. feladat
            if (azonosito1[0] == "1" || azonosito1[0] == "3")
            {
                Console.WriteLine("Az alany férfi.\n");
            }
            else
            {
                Console.WriteLine("Az alany nő.\n");
            }

            // 3. feladat
            Console.WriteLine($"Az alany születési sorszáma: {azonosito1[2]}\n");

            // 4. feladat
            Console.WriteLine($"Az alany ebben az évben a {DateTime.Now.Year - Convert.ToInt32(azonosito1[1].Substring(0, 4))}. születés napját ünnepli\n");

            // 5. feladat
            Console.Write("Írja be a személyazonosító jel első 10 számát:");
            string beker2 = Console.ReadLine();

            string[] azonosito2 = AzonositoElemzes(beker2);

            DateTime datum1 = DateTime.Parse(azonosito1[1]);
            DateTime datum2 = DateTime.Parse(azonosito1[2]);

            int azonosito1_szul = Convert.ToInt32(azonosito1[3]);
            int azonosito2_szul = Convert.ToInt32(azonosito2[3]);

            if (datum1 > datum2)
            {
                Console.WriteLine($"A(z) {beker2} azonosítójú alany született előbb");
            }
            else if (datum1 == datum2)
            {
                if (azonosito1_szul > azonosito2_szul)
                {
                    Console.WriteLine($"A(z) {beker2} azonosítójú alany született előbb");
                }
                else if (azonosito1_szul < azonosito2_szul)
                {
                    Console.WriteLine($"A(z) {beker1} azonosítójú alany született előbb");
                }
                else
                {
                    Console.WriteLine("Ugyan az az alany!");
                }
            }
            else
            {
                Console.WriteLine($"A(z) {beker1} azonosítójú alany született előbb");
            }
        }
    }
}
