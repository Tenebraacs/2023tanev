1. feladat:
CREATE TABLE szallitas
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;
 
CREATE TABLE szolgaltatas(
    id INT NOT NULL,
    tipus VARCHAR(30),
    jelentes VARCHAR(30),
    CONSTRAINT szolgaltatas PRIMARY KEY (id)
);

CREATE TABLE naptar(
    azon INT NOT NULL AUTO_INCREMENT,
    datum DATE,
    szolgid INT,
    CONSTRAINT pk_naptar PRIMARY KEY (azon),
    CONSTRAINT fk_naptar_szolgaltatas FOREIGN KEY (szolgid) REFERENCES szolgaltatas(id)
);

CREATE TABLE lakig(
    azon INT NOT NULL  AUTO_INCREMENT,
    igeny DATE,
    szolgid INT,
    mennyiseg INT,
    CONSTRAINT pk_lakig PRIMARY KEY (azon),
    CONSTRAINT fk_lakig_szolgaltatas FOREIGN KEY (szolgid) REFERENCES szolgaltatas(id)
);

2. feladat:
SELECT datum
FROM naptar
ORDER BY datum DESC
LIMIT 1;

3. feladat:


4. feladat:

5. feladat:

6. feladat:

7. feladat: