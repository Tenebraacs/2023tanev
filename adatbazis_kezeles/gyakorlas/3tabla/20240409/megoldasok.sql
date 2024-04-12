A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
CREATE DATABASE ostermelo
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;
 
 
2. feladat:
 
CREATE TABLE kiszallitasok(
sorsz INT NOT NULL,
gyumleid INT,
partnerid INT,
datum DATE,
karton INT,
CONSTRAINT pk_kiszallitasok PRIMARY KEY (sorsz),
CONSTRAINT fk_kiszallitasok_partnerek FOREIGN KEY (partnerid) REFERENCES partnerek(id),
CONSTRAINT fk_kiszallitasok_gyumolcslevek FOREIGN KEY (gyumleid) REFERENCES gyumolcslevek(id)
);
 
CREATE TABLE partnerek(
id INT NOT NULL,
kontakt VARCHAR(30),
telepules VARCHAR(30),
CONSTRAINT pk_partnerek PRIMARY KEY (id)
);
 
CREATE TABLE gyumolcslevek(
id INT NOT NULL,
gynev VARCHAR(30),
CONSTRAINT pk_gyumolcslevek PRIMARY KEY (id)
)
 
3. feladat:
SELECT DISTINCT telepules
FROM partnerek
ORDER BY name ASC;

4. feladat:

5. feladat:

6. feladat:

7. feladat:

