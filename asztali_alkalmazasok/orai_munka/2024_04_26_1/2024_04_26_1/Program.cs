using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _2024_04_26_1
{
    internal class Program
    {
        static void parose(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Ez a szám páros");
            }
            else
            {
                Console.WriteLine("Ez a szám páratlan");
            }
        }

        static void Main(string[] args)
        {
            // Készítsünk függvényt, amely eldönti, hogy a paramétere páros vagy páratlan természetes szám!

            Console.Write("Írjon be egy tetszőleges természetes számot: ");
            int x = Convert.ToInt32(Console.ReadLine());

            parose(x);


            // Írjunk olyan programot, amely bekér egy mondatot, és kiírja úgy, hogy minden szavának kezdőbetűjét nagybetűvé alakítja!

            Console.Write("Írjon be egy mondatot: ");
            string mondat = Console.ReadLine();
            StringBuilder sb = new StringBuilder(mondat);

            bool szo = true;
            for (int i = 0; i < mondat.Length; i++)
            {
                if (szo)
                {
                    sb[i] = Char.ToUpper(mondat[i]);
                    szo = false;
                }
                if (mondat[i] == ' ')
                {
                    szo = true;
                }
            }
            mondat = sb.ToString();
            Console.WriteLine(mondat);


            // Írjunk olyan programot, amely bekér egy mondatot, és kiírja minden második karakterét! 
            Console.Write("Írjon be egy mondatot: ");
            string mondat2 = Console.ReadLine();

            for(int i = 1; i < mondat2.Length; i++)
            {
                if(i % 2 != 0)
                {
                    Console.Write(mondat2[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
