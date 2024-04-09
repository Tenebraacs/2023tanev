var szam = 3;
var prime = true;

for(i = 2; i < szam; i++)
{
    if (szam % i == 0)
    {
        prime = false;
    }
}

if(prime)
{
    document.write("A szám prím\n")
}
else
{
    document.write("A szám nem prím\n")
}


//3. legnagyobb küzüs osztó

var a = 12;
var b = 18;
var m = 0;

do {
    m = b % a;
    b = a;
    a = m;
}while (m != 0);

document.write(b);



