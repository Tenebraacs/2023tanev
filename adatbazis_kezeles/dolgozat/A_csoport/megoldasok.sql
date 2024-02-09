1. feladat
CREATE DATABASE ackiado
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE regeny 
(
    id int NOT NULL,
    kategoria VARCHAR(10),
    magyar VARCHAR(150),
    angol VARCHAR(150),
    ev int,
    ar int,
    CONSTRAINT pk_regeny PRIMARY KEY (id)
);

CREATE TABLE rendeles 
(
    id int NOT NULL AUTO_INCREMENT,
    datum date,
    regenyid int,
    darab int,
    CONSTRAINT pk_rendeles PRIMARY KEY (id),
    CONSTRAINT fk_rendeles_ackiado FOREIGN KEY (regenyid) REFERENCES regeny (id)
);


2. feladat
SELECT magyar
FROM regeny
WHERE ev < 1945
ORDER BY magyar ASC;


3. feladat
SELECT magyar, angol
FROM regeny
WHERE magyar LIKE "%Poirot%" OR angol LIKE "%Poirot%";


4. feladat X
SELECT angol
FROM regeny
WHERE kategoria = "Marple"
ORDER BY ev ASC
LIMIT 1;


5. feladat X
SELECT COUNT(magyar)
FROM regeny
WHERE kategoria = NULL;


6. feladat
SELECT SUM(darab * ar) AS bevetel
FROM rendeles INNER JOIN regeny ON rendeles.regenyid = regeny.id;


7. feladat X
SELECT magyar
FROM regeny
WHERE ar = (
    SELECT ar
    FROM regeny
    WHERE magyar = „Az alibi”; 
);