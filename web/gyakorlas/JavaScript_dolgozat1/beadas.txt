/*
1.feladat: Kérjen be a felhasználótól egy egész számot és mondja meg, hogy pozitív vagy negatív! A szükséges ellenőrzéseket végezze el (például: szám-e)!
2.feladat: Írjon programot, amely előállít, majd kiír egy véletlenszámot a [1,100] intervallumból!
3.feladat: Írassa ki a 2-vel vagy 7-tel osztható 100-nál nagyobb számo(ka)t!
4.feladat: Írjon programot, amely 10-tól 1-ig visszafelé számol, majd írja ki a számok négyzetét is!
5.feladat: Írjon programot, amely meghatározza a [1,1000] intervallumban a héttel osztható számok összegét!
*/


// 1. feladat

var szam1 = prompt("Adjon meg egy ellenőrizendő számot: ");

if (szam1 > 0 && isFinite(szam1) && szam1 % 1 == 0) 
{
    document.write("Ez egy pozitív egész szám!<br>");
} 
else if (szam1 < 0 && isFinite(szam1) && szam1 % 1 == 0)
{
    document.write("Ez egy negatív egész szám!<br>");
}
else if (szam1 == 0) 
{
    document.write("A nulla se nem pozitív, se nem negatív!<br>");
}
else
{
    document.write("Ez nem egy egész szám!<br>");
}


// 2. feladat
var VeletlenSzam = Math.floor(Math.random() * 100);

document.write("<br>A véletlen generált szám: ", VeletlenSzam, "<br>")


// 3. feladat

document.write("<br>A 100-nál nagyobb 7-el vagy 2-vel osztható számok 300-ig:<br>");

for(var i = 100; i <= 300; i++)
{
    if (i % 2 == 0 || i % 7 == 0) 
    {
        document.write(i, ", ");
    }
}
document.write("<br>");


// 4. feladat

document.write("<br>10-től 1-ig a számok és négyzetgyökük:<br>")

for (var i = 10; i >= 1; i--) 
{
    document.write(i, " négyzetgyöke: ", Math.sqrt(i), "<br>");
}


// 5. feladat

var oszthato = 0;

for(var i = 1; i <= 1000; i++)
{
    if (i % 7 == 0) 
    {
        oszthato += i;
    }
}

document.write("<br>A 7-el osztható számok összege: ", oszthato)