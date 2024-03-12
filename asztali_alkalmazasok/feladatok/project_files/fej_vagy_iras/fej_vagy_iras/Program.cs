using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace fej_vagy_iras
{
    internal class Program
    {
        static string Dobas()
        {
            Random rnd = new Random();
            int dobas = rnd.Next(1, 3);

            if (dobas == 1)
            {
                return "I";
            }
            else
            {
                return "F";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. feladat");

            Console.WriteLine($"A pénfeldobás eredménye: {Dobas()}\n");


            Console.WriteLine("2. feladat");

            Console.Write("Tippeljen! (F/I)= ");
            string tip = Console.ReadLine().ToUpper();
            string dobas_ell = Dobas();

            Console.WriteLine($"A tipp {tip}, a dobás eredménye {dobas_ell} volt.");

            if (dobas_ell == tip)
            {
                Console.WriteLine("Ön eltalálta!\n");
            }
            else
            {
                Console.WriteLine("Sajnos nem találta el!\n");
            }


            Console.WriteLine("3. feladat");

            StreamReader olvas = new StreamReader("kiserlet.txt");
            List<char> dobasok = new List<char>();

            while (!olvas.EndOfStream)
            {
                dobasok.Add(Convert.ToChar(olvas.ReadLine()));
            }
            olvas.Close();

            Console.WriteLine($"A kísérlet {dobasok.Count()} dobásból állt.\n");


            Console.WriteLine("4. feladat");

            int fej = 0;

            foreach (char erme in dobasok)
            {
                if (erme == 'F')
                {
                    fej++;
                }
            }

            Console.WriteLine($"{Math.Round(fej / (dobasok.Count() / 100.0), 2)} % - ban fej a kísérlet eredménye.");


            Console.ReadKey();
        }
    }
}
