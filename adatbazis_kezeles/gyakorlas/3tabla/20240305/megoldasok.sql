1. feladat
CREATE DATABASE budapest
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE kerulet 
(
    szam VARCHAR(6) NOT NULL,
    nev VARCHAR(31),
    lakossag int,
    terulet real,
    CONSTRAINT pk_kerulet PRIMARY KEY (szam)
);

CREATE TABLE varosresz
(
    azon int NOT NULL,
    nev VARCHAR(28),
    lakossag int,
    CONSTRAINT pk_varosresz PRIMARY KEY (azon)
);

CREATE TABLE kapcsolo
(
    azon int NOT NULL,
    reszazon int,
    keruletszam VARCHAR(6),
    CONSTRAINT pk_kapcsolo PRIMARY KEY (azon),
    CONSTRAINT fk_kapcsolo_kerulet FOREIGN KEY (keruletszam) REFERENCES kerulet (szam),
    CONSTRAINT fk_kapcsolo_varosresz FOREIGN KEY (reszazon) REFERENCES varosresz (azon)
);


2. feladat
SELECT szam, nev
FROM kerulet
WHERE nev IS NOT NULL
ORDER BY nev;


3. feladat
SELECT szam, FLOOR(lakossag / terulet) AS nepsuruseg
FROM kerulet
ORDER BY nepsuruseg DESC;


4. feladat
SELECT nev, lakossag
FROM varosresz
WHERE lakossag IS NOT NULL
ORDER BY lakossag ASC;
LIMIT 1;


5. feladat
