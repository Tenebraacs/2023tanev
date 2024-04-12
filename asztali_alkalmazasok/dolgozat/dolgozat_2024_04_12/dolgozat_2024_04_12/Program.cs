using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dolgozat_2024_04_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat

            Console.WriteLine("1. feladat:");

            StreamReader olvas = new StreamReader("ipv4.txt");

            List<string> ipv4 = new List<string>();

            while (!olvas.EndOfStream)
            {
                string sor = olvas.ReadLine();
                ipv4.Add(sor);
            }

            olvas.Close();

            Console.WriteLine("Fájlbeolvasás kész...\n");


            // 2. feladat

            Console.WriteLine("2. feladat:");

            Console.WriteLine($"Az állományban {ipv4.Count()} darab adatsor van.\n");


            // 3. feladat

            Console.WriteLine("3. feladat:");

            string legnagyobb = "";

            foreach (string cim in ipv4)
            {
                if (cim.CompareTo(legnagyobb) == 1) 
                {
                    legnagyobb = cim;
                }
            }

            Console.WriteLine($"A legmagasabb IP-cím: {legnagyobb}\n");


            // 4. feladat
            
            Console.WriteLine("4. feladat:");

            int b_osztaly = 0;

            foreach (string cim in ipv4)
            {
                int cim_elso = Convert.ToInt32(cim.Substring(0, 3));
                if (cim_elso >= 128 && cim_elso <= 191)
                {
                    b_osztaly++;
                }
            }
            
            Console.WriteLine($"B osztályú címek száma: {b_osztaly} db\n");


            // 5. feladat

            Console.WriteLine("5. feladat:");

            Console.Write("Kérem adjon meg egy sorszámot: ");
            int sorszam = Convert.ToInt32(Console.ReadLine());

            StreamWriter asd = new StreamWriter("egy.txt");

            asd.WriteLine(ipv4[sorszam - 1]);

            asd.Close();

            Console.WriteLine("\nA fájl elkészült...");
        }
    }
}
