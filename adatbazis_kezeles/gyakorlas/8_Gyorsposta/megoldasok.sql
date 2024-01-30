1. feladat
CREATE DATABASE gyorsposta
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

CREATE TABLE szolgaltatas 
(
    id int NOT NULL,
    nev VARCHAR(60),
    elerheto bit,
    CONSTRAINT pk_szolgaltatas PRIMARY KEY (id)
);

CREATE TABLE ugyfel
(
    id int NOT NULL AUTO_INCREMENT,
    ablak int,
    szolgaltatasid int,
    erkezett time,
    sorrakerult time,
    tavozott time,
    CONSTRAINT pk_ugyfel PRIMARY KEY (id),
    CONSTRAINT fk_ugyfel_szolgaltatas FOREIGN KEY (szolgaltatasid) REFERENCES szolgaltatas (id)
);

2. feladat
SELECT nev
FROM szolgaltatas
WHERE elerheto;

3. feladat
SELECT MIN(erkezett), MAX(tavozott)
FROM ugyfel;

4. feladat
SELECT ablak, erkezett, nev
FROM ugyfel INNER JOIN szolgaltatas ON ugyfel.szolgaltatasid = szolgaltatas.id
WHERE sorrakerult > "12:00:00";

5. feladat
SELECT erkezett, sorrakerult, TIMEDIFF(sorrakerult, erkezett) AS varakozasi_ido
FROM ugyfel
WHERE ablak = 6
ORDER BY varakozasi_ido DESC
LIMIT 1;

6. feladat
SELECT ablak, nev AS szolgáltatás, COUNT(ugyfel.id) AS darabszám
FROM ugyfel INNER JOIN szolgaltatas ON szolgaltatas.id = ugyfel.szolgaltatasid
GROUP BY ablak, nev;

7. feladat
SELECT COUNT(id)
FROM ugyfel
WHERE sorrakerult > (SELECT MIN(tavozott) FROM ugyfel) AND erkezett <= (SELECT MIN(tavozott) FROM ugyfel);
