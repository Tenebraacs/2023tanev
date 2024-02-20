1. feladat:
CREATE DATABASE elemek
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE felfedez
(
rendszam int NOT NULL PRIMARY KEY,
vegyjel VARCHAR (5),
elemneve VARCHAR(20),
felfedezve int,
felfedezo VARCHAR(50),
gaz bit
);

2. feladat:
SELECT felfedezo, felfedezve, elemneve
FROM felfedez
WHERE felfedezo = "Hevesi György" OR felfedezo = "Müller Ferenc";

Másik megoldás:
SELECT felfedezo, felfedezve, elemneve
FROM felfedez
WHERE felfedezo in("Hevesi György", "Müller Ferenc");

3. feladat:
SELECT elemneve, rendszam, vegyjel
FROM felfedez
WHERE elemneve LIKE "%ium"
ORDER BY elemneve ASC;

4. feladat:
SELECT DISTINCT *
FROM felfedez
WHERE felfedezve BETWEEN 1800 AND 1850;

5. feladat:
SELECT elemneve
FROM felfedez
WHERE gaz = 1
ORDER BY felfedezve DESC
LIMIT 1;

6. feladat:
SELECT COUNT(rendszam) AS "Egy betűvel jelölt elemek:"
FROM felfedez
WHERE vegyjel LIKE "_";

Másik megoldás:
SELECT COUNT(rendszam) AS "Egy betűvel jelölt elemek:"
FROM felfedez
WHERE CHAR_LENGTH(vegyjel) = 1;

7. feladat:
SELECT elemneve, felfedezo
FROM felfedez
WHERE elemneve NOT IN("kalcium") AND felfedezve = 
(
    SELECT felfedezve 
    FROM felfedez 
    WHERE elemneve LIKE "kalcium"
);

Másik megoldás:
SELECT elemneve, felfedezo
FROM felfedez
WHERE elemneve != "kalcium" AND felfedezve = 
(
    SELECT felfedezve 
    FROM felfedez 
    WHERE elemneve LIKE "kalcium"
);

Másik megoldás:
SELECT elemneve, felfedezo
FROM felfedez
WHERE elemneve <> "kalcium" AND felfedezve = 
(
    SELECT felfedezve 
    FROM felfedez 
    WHERE elemneve LIKE "kalcium"
);
