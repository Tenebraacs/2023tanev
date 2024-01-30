1. feladat
CREATE DATABASE eszam
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE adalek
(
    kod VARCHAR(15) NOT NULL,
    nev VARCHAR(100),
    mellekhatas bit,
    CONSTRAINT pk_adalek PRIMARY KEY (kod)
);

CREATE TABLE funkcio
(
    az int NOT NULL AUTO_INCREMENT,
    kod VARCHAR(15),
    fnev VARCHAR(60),
    CONSTRAINT pk_funkció PRIMARY KEY (az),
    CONSTRAINT fk_funkcio_adalek FOREIGN KEY (kod) REFERENCES adalek (kod)
);


2. feladat
SELECT nev
FROM adalek
WHERE mellekhatas
ORDER BY nev ASC;

3. feladat
SELECT DISTINCT nev, fnev
FROM funkcio INNER JOIN adalek ON funkcio.kod = adalek.kod
WHERE nev LIKE "%karamell%";

4. feladat
