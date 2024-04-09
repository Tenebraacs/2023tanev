// egysoros megjegyzés

/*
Többsoros megjegyzés
*/

/*
Fontos:
- Külső fájlban nem adjuk meg a <script></script> címkét.
- Kis és nagybetű között különbség van
- Pontosvesszővel zárjuk az utasításokat
*/

document.write("Hello World!");

// Szövegben alkalmazhatunk HTML formázást is.

document.write("<b>Hello</b> World!<br>");

// Aposztrófjelek elhagyása
document.write('1 + 1 = ', 1 + 1, '<br>');

//VÁLTOZÓK
/* 
- Addig őrzi meg a tartalmát, amíg felül nem írjuk.
- Az értékadással azt is megmondjuk, hogy milyen típusú adatot kívánunk tárolni.

Szabályok:
- kis és nagybetű között különbséget tesz
- A JavaScript kulcsszavait nem használhatjuk.
- betűvel, aláhúzásjellel vagy dollárjellel kezdődhetnek
*/

document.write(kutya, '<br>'); //nincs létrehozva a kutya változó

var kutya = 101;
document.write(kutya, '<br>');
document.write(kutya + 1, '<br>');
document.write(kutya + 2, '<br>');

//Három elemi adattípus: szám, szöveg, logikai
var a = 3;
var b = 2.5;
document.write('T = ', a * b, ' cm<sup>2</sup> <br>');

var c = 'alma';
var d = 'fa';
document.write('Két string konkatenációja (összefűzés): ', c + d, '<br>');

var f = false;
document.write('Logikai változó: ', f, ' és ellentettje: ', !f, '<br>');

/*
VEZÉRLÉSI SZERKEZETEK
- szekvencia: utasítások egymás utáni végrehajtása
- szelekció: feltételes elágazás
- iteráció: ciklus
*/ 

// Döntsük el egy számról, hogy páros vagy páratlan!

var a = 42;
if (a % 2 == 0)
{
    document.write(a, ' szám páros <br>');
}
else
{
    document.write(a, ' szám páratlan <br>');
}

//prompt utasítás: futási időben kérhetünk be a felhasználótól adatot.

var b = prompt('Kérek egy számot - b: ');
/*
if (b % 2 == 0)
{
    document.write(b, ' szám páros <br>');
}
else
{
    document.write(b, ' szám páratlan <br>');
}
*/

//isFinite() - logikai igaz értéket ad vissza, ha a paramétere szám típusú

if (isFinite(b)) {
    if (b % 2 == 0)
    {
        document.write(b, ' szám páros <br>');
    }
    else
    {
        document.write(b, ' szám páratlan <br>');
    }
}
else 
{
    document.write(b, ' nem szám <br>');
}

//Math.floor() függvény: a paraméterként kapott szám egészrészét adja vissza
var d = prompt('d = ', '0');
if (isFinite(d)) 
{
    if (Math.floor(d) == d) //Egész szám-e 
    {
        if (a % 2 == 0)
        {
            document.write(d, ' szám páros <br>');
        }
        else
        {
            document.write(d, ' szám páratlan <br>');
        }
    }
    else 
    {
        document.write(d, ' nem egész szám <br>');
    }
}
else 
{
    document.write(d, ' nem szám <br>');
}

// Kérjünk be a felhasználótól egy 100-nál nagyobb páros számot!

var szam = prompt('Adjon meg egy 100-nál nagyobb, páros számot: ')
if (szam < 100 && szam % 2 == 0) 
{
    document.write('Nagyon okos vagy <br>');
}
else
{
    document.write('Öld meg magad');
}