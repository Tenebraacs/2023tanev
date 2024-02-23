using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("1. feladat");
            Console.Write("\tKérem adja meg az 52. hét lottószámait: ");

            int[] sor = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(sor);


            Console.WriteLine("2. feladat");
            Console.Write("\tAz 52. hét lottószámai emelkedő sorrendben: ");

            foreach (int i in sor) {  Console.Write($"{i} "); }
            Console.WriteLine();


            Console.WriteLine("3. feladat");
            Console.Write("\tKérem adjon meg egy egész számot: ");

            int szam = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("4. feladat");
            int[,] lotto_szamok = new int[51, 5];
            StreamReader be = new StreamReader("lotttosz.dat");

            for (int i = 0; i < 51; i++)
            {
                sor = be.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for ( int j = 0; j < 5; j++ )
                {
                    lotto_szamok[i, j] = sor[j];
                }
            }
            be.Close();

            Console.Write($"\tA {szam}. hét nyerőszámai: ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write("{0}", lotto_szamok[szam - 1, i]);
            }
            Console.WriteLine();
            */

            Console.Write("Adja meg a feladatot: ");
            int fel = Convert.ToInt32(Console.ReadLine());

            if (fel == 1)
            {
                //1.Példa
                //Állítsunk elő véletlenszerűen 5 egész számot és írjuk ki fájlba is ezeket!

                Random r_num = new Random();
                string file1 = "ki.txt";
                StreamWriter fwrite = new StreamWriter(file1);
                for (int i = 0; i < 5; i++)
                {
                    fwrite.Write($"{r_num.Next(1, 10)}, ");
                }
                fwrite.Close();

            }

            else if (fel == 2)
            {
                //2.pálda
                //Olvassuk be a nevek.txt fájlt, amely 4 nevet tartalmaz (minegyik név külön sorban van)!

                StreamReader read = new StreamReader("nevek.txt");
                /*
                string[] nevekTomb = new string[4];
                for(int i = 0;i < nevekTomb.Length;i++)
                {
                    nevekTomb[i] = read.ReadLine();
                    Console.WriteLine(nevekTomb[i]);
                }
                read.Close();
                */

                //Ha nem tudjuk melőre hány adatot kell beolvasni
                List<string> neveklista = new List<string>();
                while (!read.EndOfStream)
                {
                    neveklista.Add(read.ReadLine());
                }
                read.Close();

                for (int i = 0; i < neveklista.Count; i++)
                {
                    Console.WriteLine(neveklista[i]);
                }
            }

            else if (fel == 3)
            {
                Console.WriteLine("1.feladat: ");
                Console.Write("\tKérem adja meg az 52. hét lottószámait: ");
                string[] sor = Console.ReadLine().Split(' ');

                int[] szamok = new int[5];
                for (int i = 0; i < szamok.Length; i++)
                {
                    szamok[i] = Convert.ToInt32(sor[i]);
                }
                Console.WriteLine("2.feladat: ");
                for (int i = 0; i < szamok.Length; i++)
                {
                    int min = i;
                    for (int j = i + 1; j < szamok.Length; j++)
                    {
                        if (szamok[min] < szamok[j])
                        {
                            min = j;
                        }
                    }
                    int cs = szamok[i];
                    szamok[i] = szamok[min];
                    szamok[min] = cs;
                }

                //Array.Sort(szamok)

                Console.Write("\tAz 52.hét lottószámai emelkedő sorrendben: ");
                for (int i = 0; i < szamok.Length; i++)
                {
                    Console.Write($"{szamok[i]} ");
                }
                Console.WriteLine();


                int sz1 = 0;
                do
                {
                    Console.Write("Adjon meg egy egyész számot 1 - 51 között: ");
                    sz1 = Convert.ToInt32(Console.ReadLine());
                }
                while (sz1 < 1 || sz1 > 51);

                Console.WriteLine("4. feladat");
                int[,] lista = new int[52, 5];
                StreamReader be = new StreamReader("lottosz.dat");

                for (int i = 0; i < 51; i++)
                {
                    sor = be.ReadLine().Split(' ');
                    for (int j = 0; j < 5; j++)
                    {
                        lista[i, j] = Convert.ToInt32(sor[j]);
                    }
                }
                be.Close();

                //Ellenőrzés
                /*for (int i = 0; i < 51; i++)
                 * {
                 *  for (int j = 0; j < 5; j ++
                 *  {
                 *      Console.Write("{0} ", Lista[i, j]);
                 *  }
                 *  Console.WriteLine();
                 *  }*/

                Console.Write("\tA {0}. hét nyerőszámai: ", sz1);
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("{0} ", lista[sz1 - 1, i]);
                }
                Console.WriteLine();

                Console.WriteLine("5. feladat: ");

                int[] darab = new int[91];
                for (int i = 0; i < darab.Length; i++)
                {
                    darab[i] = 0;
                }

                for (int i = 0; i < 51; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        darab[lista[i, j]]++;
                    }
                }

                //Eldöntés tétel
                int k = 1;
                while (k < darab.Length && darab[k] != 0)
                {
                    k++;
                }
                bool vane = k < darab.Length;

                if (vane)
                {
                    Console.WriteLine("\tVan");
                }
                else
                {
                    Console.WriteLine("\tNincs");
                }
                int paratlan = 0;
                for (int i = 0; i < darab.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        paratlan = paratlan + darab[i];
                    }
                }
                Console.WriteLine($"{paratlan}db páratlan számot húztak ki.");
                /*
                int db = 0;
                for (int i = 0; i < 51; i++)
                {
                    for (int j =0; j < 5; j++)
                    {
                        if (lista[i, j] %2 == 1) {
                            db++;
                        }
                    }
                }
                */

                for (int i = 0; i < 5; i++)
                {
                    lista[51, i] = szamok[i];
                }

                StreamWriter ki = new StreamWriter("lotto52.ki");
                for (int i = 0; i < 52; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        ki.Write("{0} ", lista[i, j]);
                    }
                    ki.WriteLine();


                }
                ki.Close();
                Console.WriteLine("\tlotto52.ki fájl elkészült");

                Console.WriteLine("8.feladat: ");
                for (int i = 0; i < 5; i++)
                {
                    darab[lista[51, i]]++;
                }

                for (int i = 1; i < 91; i++)
                {
                    Console.Write("{0} ", darab[i]);
                }


            }
            else
            { Console.WriteLine("nem (NOPE)"); }
        }
    }
}
