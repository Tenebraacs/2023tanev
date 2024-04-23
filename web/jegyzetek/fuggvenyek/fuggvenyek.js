// FÜGGVÉNYEK

// Eljárás
function eljaras(s) {
    document.write(s, '<br>');
}

// Eljárás meghívása
eljaras('almaspite'); // 'almáspite' - aktuális paraméter

// Függvény
function negyzetT(a) {
    var T = a * a;
    return T;
}

var terulet = negyzetT(2);

eljaras(terulet);

// Feladat: Vizsgálja meg, hogy a paraméterként kapott év szökőév-e
function szokoev(szev) {
    return (szev % 4 == 0 && szev % 100 != 0) || (szev % 400 == 0);
}

var ev = 2001;

if (szokoev(ev)) {
    eljaras(ev + ' év szökőév');
} else {
    eljaras(ev + ' év nem szökőév');
}

// Feladat: írjunk programot, amely kiírja a tömb elemeit!
function tombFeltolt(a, elemszam, min, max) {
    var intervallum = max - min;
    for (i = 0; i < elemszam; ++i) {
        a[i] = Math.round(Math.random() * intervallum) + min;
    }
    return a;
}

// Feladat: írjunk programot, amely kiírja a tömb elemeit!
function tombKiir(a) {
    for (i = 0; i < a.length; ++i) {
        document.write(a[i], ', ');
    }
}
document.write('<br>');

var tomb = new Array();
tomb = tombFeltolt(tomb, 100, 1, 1000);
tombKiir(tomb);


// Feladat: Keressük meg a tömb legnagyobb elemét!

var max = 0;
for (i = 0; i < tomb.length; ++i)
{
    if (tomb[i] > tomb[max])
    {
        max = i;
    }
}

document.write('<br>A legnagyobb elem: ', tomb[max]);

//Feladat: Számoljuk ki a tömb páros elemeinek az átlagát!

var paros_ossz = 0;
var paros = 0;

for (i = 0; i < tomb.length; ++i)
{
    if (tomb[i] % 2 == 0)
    {
        paros++;
        paros_ossz += tomb[i];
    }
}

document.write('<br>A páros számok átlaga: ', Math.round(paros_ossz / paros))