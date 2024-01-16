1. feladat
CREATE DATABASE diafilmek
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE kiado
(
    id int NOT NULL,
    nev VARCHAR(90),
    CONSTRAINT pk_kiado PRIMARY KEY (id)
);

CREATE TABLE film 
(
    id int NOT NULL,
    cim VARCHAR(160),
    kiadasiev int,
    kocka int,
    szinese bit,
    kiadoid int,
    CONSTRAINT pk_film PRIMARY KEY (id),
    CONSTRAINT fk_film_kiado FOREIGN KEY (kiadoid) REFERENCES kiado (id)
);

2. feladat
SELECT cim, kiadasiev
FROM film
WHERE kiadasiev > 2000
ORDER BY cim ASC;

3. feladat
SELECT cim, kocka, kiadasiev
FROM film
WHERE cim LIKE "%farkas%";

4. feladat X
SELECT DISTINCT nev
FROM film INNER JOIN kiado ON film.kiadoid = kiado.id
WHERE cim LIKE "%Sicc%";

5. feladat
SELECT cim, COUNT(cim) AS "Kiadások száma"
FROM film
GROUP BY cim
ORDER BY COUNT(cim) DESC
LIMIT 1;

6. feladat
SELECT kiadasiev, 
COUNT(kiadasiev) AS "Ennyi film jelent meg ebben az évben:"
FROM film
WHERE kiadasiev NOT NULL
GROUP BY kiadasiev
ORDER BY COUNT(kiadasiev) DESC;

7. feladat
SELECT DISTINCT cim
FROM film
WHERE szinese = 0 OR szinese = 1;