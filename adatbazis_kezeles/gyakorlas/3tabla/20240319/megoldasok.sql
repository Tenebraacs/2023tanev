A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!

1. feladat:
CREATE DATABASE varosok
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;


2. feladat:
CREATE TABLE megye
(
    id int NOT NULL,
    mnev VARCHAR(128),
    CONSTRAINT pk_megye PRIMARY KEY (id)
);

CREATE TABLE varostipus
(
    id int NOT NULL,
    vtip VARCHAR(128),
    CONSTRAINT pk_varostipus PRIMARY KEY (id)
);

CREATE TABLE varos
(
    id int NOT NULL,
    vnev VARCHAR(128),
    vtipid int,
    megyeid int,
    jaras VARCHAR(128),
    kisterseg VARCHAR(128),
    nepesseg int,
    terulet real,
    CONSTRAINT pk_varos PRIMARY KEY (id),
    CONSTRAINT fk_varos_megye FOREIGN KEY (megyeid) REFERENCES megye (id),
    CONSTRAINT fk_varos_varostipus FOREIGN KEY (vtipid) REFERENCES varostipus (id)
);


3. feladat:
SELECT vnev
FROM varos
WHERE vnev LIKE "%vásár%";


4. feladat:
SELECT vnev, nepesseg, terulet
FROM varos
WHERE terulet > 400
ORDER BY nepesseg DESC;


5. feladat:
SELECT vnev, nepesseg
FROM varos INNER JOIN megye ON varos.megyeid = megye.id
WHERE mnev = 'Fejér' AND nepesseg > 15000;


6. feladat:
SELECT vtip AS 'Város típusa', COUNT(varos.id) AS 'Városok száma', SUM(nepesseg) AS Népesség 
FROM varos INNER JOIN varostipus ON varos.vtipid = varostipus.id
WHERE vtip <> "Főváros"
GROUP BY vtip;


7. feladat:

