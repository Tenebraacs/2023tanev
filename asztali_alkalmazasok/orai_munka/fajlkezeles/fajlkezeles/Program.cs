 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fajlkezeles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              FÁJLKEZELÉS

            - IO (Input/Output) osztályokra van szükség.
            - Ezeket az osztályokat a using System.IO; segítségével érhetjük el.

            1. StreamWriter - fájlba írás
            a program bin / debug mappájába találjuk meg

            string fizikaifajlnev = "fajl.txt";

            A programban nem használjuk a fizikai fájl nevét, helyette egy logikai fájlnévvel dolgozunk.

            StreamWriter logikaifajlneve = new StreamWriter(fizikaifajlneve);

            A végén be kell zárni a fájlt minden esetben:
            logikaifajlneve.Close();

            2. StreamReader - fájlba olvasás
            StreamReader logikaifajl = new StreamReader(fizikaifajlnev);
             */


            // 1. példa
            // Állítsunk elő véletlenszerűen 5 egész számot és írjuk ki fájlba is ezeket!

            Random rnd = new Random();
            string fajlnev = "ki.txt";
            StreamWriter kiir = new StreamWriter(fajlnev);

            for ( int i = 0; i < 5; i++ )
            {
                kiir.Write($"{rnd.Next(1, 10)}, ");
            }
            kiir.Close();

            
            // 2. példa
            // Olvassuk be a nevek.txt fájlt, amely 4 nevet tartalmaz (mindegyik név külön sorban van)!

            StreamReader olvas = new StreamReader("nevek.txt");
            /*
            string[] nevekTomb = new string[4];

            for ( int i = 0; i < 4; i++ ) 
            {
                nevekTomb[i] = olvas.ReadLine();
                Console.WriteLine(nevekTomb[i]);
            }
            olvas.Close();
            */


            // 2. példára 2. megoldás (ha nem tudjuk előre, hogy hány adatot kell beolvasni)

            List<string> nevekLista = new List<string>();
            
            while (!olvas.EndOfStream)
            {
                nevekLista.Add(olvas.ReadLine());
            }
            olvas.Close();

            foreach ( string n in nevekLista ) { Console.WriteLine(n); }

            Console.ReadKey();
        }
    }
}