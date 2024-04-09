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

//Adjuk össze 1-től 100-ig a számokat!
var szamok = 0;

for (i = 1; i <= 100; i++) 
{
    szamok += i;
}

document.write("1-től 100-ig összeadva a számok: ", szamok, "<br>")

// 11. feladat

var oszthato = 0;

for (i = 1; i <= 10000; i++)
{
    if (i % 7 == 0)
    {
        oszthato++;
    }
}

document.write("1 és 10000 között ", oszthato, ", 7-el osztható szám van" );

//Kérjünk be egy pozití egész számot

// 1.megoldás

var a = 0;
var ok = false;
do
{
    a = prompt('Kérek egy számot: ');
    if (isFinite(a))
    {
        if (a > 0)
        {
            ok = true;
        }
    }
}while(!ok);

// 2. megoldás

do
{
    a = prompt('Kérek egy számot: ');
}while(!(isFinite(a) && a > 0 && Math.floor(a) == a));

//Véletlenszám előállító függvény

document.write(Math.floor(Math.random() * 10))