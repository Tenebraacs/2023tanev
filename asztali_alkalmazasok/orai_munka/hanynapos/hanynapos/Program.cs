using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hanynapos
{
    internal class Program
    {
        static int ev, honap, nap, ora, perc, mperc;
        static DateTime szulnap;
        static string s = "", s1 = "";
        static void Main(string[] args)
        {
            /*
            Kérjünk be egy születésnapot (órára pontosan), majd számoljuk és írjuk ki, hogy hány hónapos napos és hány órás az illető!
            A kiírásnál használjuk a könnyebb olvashatóság miatt a hármas tagolást (ezres csoportosítás)!
            */

            Console.WriteLine("Kérem a születés adatait!");
            adatbekeres();
            szulnap = new DateTime(ev, honap, nap, ora, perc, mperc);

            s = Convert.ToString(DateTime.Now.Subtract(szulnap).Days);

            fordit();
            szokoz();
            Console.Write("Ennyi napos vagy: ");
            visszafordit();

            int oraszam = Convert.ToInt32(Math.Round(DateTime.Now.Subtract(szulnap).TotalHours));

            s = Convert.ToString(oraszam);
            fordit();
            szokoz();
            Console.Write("\nEnnyi órás vagy: ");
            visszafordit();
        }

        static void adatbekeres()
        {
            Console.Write("év =");
            ev = Convert.ToInt32(Console.ReadLine());

            Console.Write("hónap =");
            honap = Convert.ToInt32(Console.ReadLine());

            Console.Write("nap =");
            nap = Convert.ToInt32(Console.ReadLine());

            Console.Write("óra =");
            ora = Convert.ToInt32(Console.ReadLine());

            perc = mperc = 0;
        }

        static void fordit()
        {
            s1 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s1 = s1 + s[i].ToString();
            }
            s = s1;
        }

        static void szokoz()
        {
            s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                s1 = s1 + s[i].ToString();
                if ((i + 1) % 3 == 0)
                {
                    s1 = s1 + " ";
                }
            }
        }

        static void visszafordit()
        {
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                Console.Write(s1[i]);
            }
        }
    }
}
