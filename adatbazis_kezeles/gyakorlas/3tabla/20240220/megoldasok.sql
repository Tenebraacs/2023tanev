1. feladat
CREATE DATABASE forgalom
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE megnevezes
(
    id int NOT NULL,
    nev VARCHAR(64),
    CONSTRAINT pk_megnevezes PRIMARY KEY (id)
);

CREATE TABLE mertek
(
    id int NOT NULL,
    nev VARCHAR(64),
    CONSTRAINT pk_mertek PRIMARY KEY (id)
);

CREATE TABLE korlatozas 
(
    az int NOT NULL AUTO_INCREMENT,
    utszam int,
    kezdet real,
    veg real,
    telepules VARCHAR(128),
    mettol date,
    meddig date,
    megnevid int,
    mertekid int,
    sebesseg int,
    CONSTRAINT pk_korlatozas PRIMARY KEY (az),
    CONSTRAINT fk_korlatozas_megnevezes FOREIGN KEY (megnevid) REFERENCES megnevezes (id),
    CONSTRAINT fk_korlatozas_mertek FOREIGN KEY (mertekid) REFERENCES mertek (id)
);

2. feladat
SELECT utszam, kezdet, veg, mettol, meddig
FROM korlatozas
WHERE telepules LIKE "Miskolc";

3. feladat
SELECT telepules, DATEDIFF(meddig, mettol) AS "napok_szama"
FROM korlatozas
ORDER BY napok_szama DESC;

4. feladat
SELECT DISTINCT telepules
FROM korlatozas INNER JOIN megnevezes ON korlatozas.megnevid = megnevezes.id
WHERE nev LIKE 'csomópont építés';

5. feladat
SELECT COUNT(telepules)
FROM korlatozas
WHERE utszam >= 1000 AND utszam <= 9999;

6. feladat
SELECT nev, AVG(veg - kezdet)
FROM korlatozas INNER JOIN mertek ON korlatozas.mertekid = mertek.id
WHERE nev NOT LIKE 'teljes lezárás'
GROUP BY nev;