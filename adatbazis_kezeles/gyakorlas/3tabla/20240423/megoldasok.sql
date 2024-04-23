1. feladat:
CREATE DATABASE nezok
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE meccs 
(
    id int NOT NULL,
    datum date,
    kezdes time,
    belepo int,
    tipus VARCHAR(16),
    CONSTRAINT pk_meccs PRIMARY KEY (id)
);

CREATE TABLE nezo
(
    id int NOT NULL,
    nev VARCHAR(128),
    ferfi bit,
    berletes bit,
    CONSTRAINT pk_nezo PRIMARY KEY (id)
);

CREATE TABLE belepes
(
    nezoid int NOT NULL,
    meccsid int,
    idopont time,
    CONSTRAINT pk_belepes PRIMARY KEY (nezoid, meccsid),
    CONSTRAINT fk_belepes_nezo FOREIGN KEY (nezoid) REFERENCES nezo (id),
    CONSTRAINT fk_belepes_meccs FOREIGN KEY (meccsid) REFERENCES meccs (id)
);

2. feladat:
SELECT datum
FROM meccs
WHERE tipus LIKE "bajnoki"
ORDER BY datum ASC;

3. feladat:
SELECT belepo
FROM meccs
ORDER BY datum DESC
LIMIT 1;

4. feladat:
SELECT datum AS 'Mérkőzés dátuma', COUNT(id) AS 'Nézők száma'
FROM meccs INNER JOIN belepes ON id = meccsid
GROUP BY datum;

5. feladat:
SELECT SUM(belepo) AS 'Bevétel'
FROM belepes INNER JOIN meccs ON belepes.meccsid = meccs.id
INNER JOIN nezo ON belepes.nezoid = nezo.id
WHERE berletes = 0 AND datum BETWEEN '2018-09-01' AND '2018-09-30';

6. feladat:

7. feladat: