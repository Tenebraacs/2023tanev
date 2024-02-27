1. feladat
CREATE DATABASE viz
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE szerelo
(
    az int NOT NULL,
    nev VARCHAR(64),
    kezdev int,
    CONSTRAINT pk_szerelo PRIMARY KEY (az)
);

CREATE TABLE hely
(
    az int NOT NULL,
    telepules VARCHAR(64),
    utca VARCHAR(64),
    CONSTRAINT pk_hely PRIMARY KEY (az)
);

CREATE TABLE munkalap
(
    az int NOT NULL AUTO_INCREMENT,
    bedatum date,
    javdatum date,
    helyaz int,
    szereloaz int,
    munkaora int,
    anyagar int,
    CONSTRAINT pk_munkalap PRIMARY KEY (az),
    CONSTRAINT fk_munkalap_szerelo FOREIGN KEY (szereloaz) REFERENCES szerelo (az),
    CONSTRAINT fk_munkalap_hely FOREIGN KEY (helyaz) REFERENCES hely (az)
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