A feladatok megoldására elkészített SQL parancsokat illessze be a feladat sorszáma után!


1. feladat:
CREATE DATABASE teke
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

2. feladat
CREATE TABLE egyesuletek
(
    id int NOT NULL,
    nev VARCHAR(120),
    CONSTRAINT pk_egyesuletek PRIMARY KEY (id)
);

CREATE TABLE versenyzok
(
    rajtszam int NOT NULL,
    nev VARCHAR(120),
    egyid int,
    korcsop varchar(120),
    CONSTRAINT pk_versenyzok PRIMARY KEY (rajtszam),
    CONSTRAINT fk_versenyzok_egyesuletek FOREIGN KEY (egyid) REFERENCES egyesuletek (id)
);

CREATE TABLE eredmenyek
(
    sorsz int NOT NULL,
    versenyzo int,
    teli int,
    tarolas int,
    ures int,
    CONSTRAINT pk_eredmenyek PRIMARY KEY (sorsz),
    CONSTRAINT fk_eredmenyek_versenyzok FOREIGN KEY (versenyzo) REFERENCES versenyzok (rajtszam)
);

3. feladat:


4. feladat:


5. feladat:


6. feladat:


7. feladat:

