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
    document.write("A szám prím")
}
else
{
    document.write("A szám nem prím")
}


//2. prímtényezős felbontás



