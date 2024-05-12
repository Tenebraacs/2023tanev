using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adjon meg egy karaktersorozatot: ");
        string bemenet = Console.ReadLine();

        // Feladat 1: Karaktersorozat minden karakterének megduplázása
        string megduplazott = DuplazKaraktereket(bemenet);
        Console.WriteLine("Az eredmény (feladat 1): " + megduplazott);

        // Feladat 2: Karaktersorozat középső karaktere vagy első fele
        KozepVagyElsoFelte(bemenet);

        // Feladat 3: 'e' és 'i' betűk előfordulásának megszámlálása
        SzamolEsKiir(bemenet);

        // Feladat 4: 'a' betűk kiíratása annyiszor, ahány van
        KiirBetutA(bemenet);

        // Fájlba írás
        FajlbaIras(bemenet, megduplazott);
    }

    static string DuplazKaraktereket(string szoveg)
    {
        string megduplazott = "";
        foreach (char karakter in szoveg)
        {
            megduplazott += karakter.ToString() + karakter.ToString();
        }
        return megduplazott;
    }

    static void KozepVagyElsoFelte(string szoveg)
    {
        if (szoveg.Length % 2 == 1)
        {
            int kozepIndex = szoveg.Length / 2;
            Console.WriteLine("A középső karakter (feladat 2): " + szoveg[kozepIndex]);
        }
        else
        {
            int felhossz = szoveg.Length / 2;
            string elsoFel = szoveg.Substring(0, felhossz);
            Console.WriteLine("Az első felének karakterei (feladat 2): " + elsoFel);
        }
    }

    static void SzamolEsKiir(string szoveg)
    {
        int eSzamlalo = 0;
        int iSzamlalo = 0;

        foreach (char karakter in szoveg)
        {
            if (karakter == 'e' || karakter == 'E')
                eSzamlalo++;
            else if (karakter == 'i' || karakter == 'I')
                iSzamlalo++;
        }

        Console.WriteLine($"Az 'e' betű előfordulása (feladat 3): {eSzamlalo}");
        Console.WriteLine($"Az 'i' betű előfordulása (feladat 3): {iSzamlalo}");
    }

    static void KiirBetutA(string szoveg)
    {
        int aSzamlalo = 0;
        foreach (char karakter in szoveg)
        {
            if (karakter == 'a' || karakter == 'A')
                aSzamlalo++;
        }

        for (int i = 0; i < aSzamlalo; i++)
        {
            Console.WriteLine("a (feladat 4)");
        }
    }

    static void FajlbaIras(string bemenet, string megduplazott)
    {
        string fajlNev = "eredmeny.txt";
        using (StreamWriter iras = new StreamWriter(fajlNev))
        {
            iras.WriteLine($"Bekért karaktersorozat: {bemenet}");
            iras.WriteLine($"Az eredmény (feladat 1): {megduplazott}");
        }

        Console.WriteLine($"Az eredményt a(z) {fajlNev} fájlba írtam.");
    }
}
