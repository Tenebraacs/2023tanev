1. feladat
CREATE DATABASE statisztika
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

2. feladat
CREATE TABLE telepules 
(
telepaz int NOT NULL PRIMARY KEY,
megnevezes VARCHAR(50),
rang VARCHAR(50),
kisterseg VARCHAR(50),
terulet int,
nepesseg int,
lakas int
);

3. feladat
-

4. feladat
SELECT megnevezes, nepesseg
FROM telepules
WHERE rang = "község" AND nepesseg < 1000
ORDER BY megnevezes ASC;

5. feladat
SELECT megnevezes
FROM telepules
WHERE kisterseg IN ("Makói", "Csongrádi")
ORDER BY terulet ASC
LIMIT 1;

6. feladat
SELECT megnevezes, ROUND(nepesseg / terulet) AS "Népsűrűség"
FROM telepules
WHERE nepesseg / terulet > 1
ORDER BY nepesseg / terulet DESC;

7. feladat
SELECT kisterseg, COUNT(megnevezes) AS "Települések száma",
SUM(nepesseg) AS "Össznépség"
FROM telepules
GROUP BY kisterseg;

8. feladat
CREATE TABLE telepules2 LIKE telepules;
INSERT INTO telepules2 SELECT * FROM telepules;

DELETE FROM telepules2
WHERE lakas BETWEEN 200 AND 400;

9. feladat
SELECT *
FROM telepules
GROUP BY kisterseg;
