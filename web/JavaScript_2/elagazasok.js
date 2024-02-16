/*A középszintű érettségin maximum 150 pont szerezhető. Kérje be egy tanuló elért pontszámát és írja ki, milyen érdemjegyet kapott (betűvel és számmal) ha a százalékos értékelés a következő:
0-19% - elégtelen (1)
20-39% - elégséges (2)
40-59% - közepes (3)
60-79% - jó (4)
80-100% - jeles (5)*/

var pont = prompt("A tanuló pontszáma: ")

var szazalek = Math.floor(pont / (150 / 100))

if (szazalek < 20) 
{
    document.write("A tanuló ", szazalek, " %-ot ért el, és elégtelen (1) osztályzatot szerzett!<br>")
}
else if (szazalek < 40)
{
    document.write("A tanuló ", szazalek, " %-ot ért el, és elégséges (2) osztályzatot szerzett!<br>")
}
else if (szazalek < 60)
{
    document.write("A tanuló ", szazalek, " %-ot ért el, és közepes (3) osztályzatot szerzett!<br>")
}
else if (szazalek < 80)
{
    document.write("A tanuló ", szazalek, " %-ot ért el, és jó (4) osztályzatot szerzett!<br>")
}
else 
{
    document.write("A tanuló ", szazalek, " %-ot ért el, és jeles (5) osztályzatot szerzett!<br>")
}

// Ciklusok - (ciklus = iteráció)
// Számlálós ciklus
/*
for (kezdőérték; feltétel; lépésszám)
{
    ciklusmag;
}
*/

// 5. feladat: Számoljunk el 0-tól 20-ig, és az értékeket jelenítsük meg.

for (i = 0; i <= 20; ++i) 
{
    document.write(i, "<br>");
}

// 6. feladat

for (i = 0; i < 20; i += 2)
{
    document.write(i, ' ', Math.sqrt(i), '<br>');
}


// 7. feladat

for (i = 20; i > 0; i--) 
{
    document.write(i, "<br>");
}


// 8. feladat

for (i = 0; i < 20; i += 3)
{
    document.write(i, "<br>");
}


// 9. feladat

for (i = 1; i < 100; i++)
{
    if (i % 7 == 0)
    {
        document.write(i, "<br>")
    }
}