1. feladat:
CREATE DATABASE allamok
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE orszagok
(
allam VARCHAR (50) NOT NULL PRIMARY KEY,
allamforma VARCHAR (30),
terulet int,
nepesseg int,
foldresz VARCHAR(50)
);

INSERT INTO orszagok (allam, allamforma, terulet, nepesseg, foldresz) VALUES 
('Belize', 'köztársaság', 22965, 189, 'Közép-Amerika');

2. feladat:
SELECT DISTINCT *
FROM orszagok
WHERE allam LIKE "%szigetek%";

3. feladat:
SELECT allam
FROM orszagok
WHERE terulet > 500000 AND foldresz = "Afrika" OR "Dél-Amerika"
ORDER BY terulet DESC;

4. feladat:
SELECT allam, nepesseg
FROM orszagok
ORDER BY terulet ASC
LIMIT 3;

5. feladat:
SELECT COUNT(foldresz) AS "Afrikai államok száma:", COUNT(terulet), COUNT(nepesseg)

6. feladat:


7. feladat:



