//KARAKTERLÁNC TÍPUSOK

var s1 = "Almáspite";
document.write(s1, '<br>');

var s2 = new String("Almáspite");
document.write(s2, '<br>');

var s3 = new String(""); //üres string
document.write(s3, '<br>');

var s4 = new String;
document.write(s4, '<br>');

document.write("Szöveg hossza: ", s1.length, "<br>");
document.write("Szöveg első karaktere: ", s1.charAt(0), "<br>");
document.write("Szöveg utolsó karaktere: ", s1.charAt(s1.length - 1), "<br>");

// 1. feladat
// Írjuk ki a felhasználótól bekért szöveget karakterenként egymás alá!

var szoveg1 = prompt("Írjon be egy szöveget amit karakterenként szeretne kiíratni: ");

for(i = 0; i < szoveg1.length; i++)
{
    document.write(szoveg1.charAt(i), '<br>');
}


// 2. feladat

var szoveg2 = prompt("megfordítás");

for(i = szoveg2.length -1; i >= 0; i--)
{
    document.write(szoveg2.charAt(i));
}

document.write("Lekérdezi az sz1 változó értékét: ", sz1.valueOf());
document.write("<br>");

