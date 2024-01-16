1. feladat
CREATE DATABASE elte
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

2. feladat
CREATE TABLE szak
(
    az int NOT NULL,
    nev VARCHAR(50),
    kar VARCHAR(30),
    CONSTRAINT pk_szak PRIMARY KEY (az)
);

CREATE TABLE jelentkezes 
(
    az int NOT NULL AUTO_INCREMENT,
    ev int,
    szakaz int,
    ossz int,
    elso int,
    felvett int,
    pont int,
    forma CHAR(1),
    munkarend CHAR(1),
    tamogatott bit,
    CONSTRAINT pk_jelentkezes PRIMARY KEY (az),
    CONSTRAINT fk_jelentkezes_szak FOREIGN KEY (szakaz) REFERENCES szak (az)
);

2. feladat
SELECT nev, kar
FROM szak
WHERE nev LIKE "%olasz%"
ORDER BY nev ASC;

3. feladat
SELECT ev, SUM(felvett)
FROM jelentkezes
WHERE forma = "A" OR forma = "O"
GROUP BY ev;

4. feladat
SELECT COUNT(az)
FROM jelentkezes
WHERE elso < ossz / 10;

5. feladat
SELECT nev
FROM szak
WHERE nev != "fizikus" AND kar IN (SELECT kar FROM szak WHERE nev = "fizikus");

6. feladat
SELECT kar, nev, forma, pont
FROM jelentkezes, szak
WHERE ev = 2012 AND munkarend = "N" AND tamogatott = 1
ORDER BY nev ASC;