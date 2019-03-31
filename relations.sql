CREATE TABLE lECTURER(
ID INT PRIMARY KEY NOT NULL,
NAME TEXT NOT NULL,
TITLE TEXT NOT NULL,
CAR_ID INT,
FOREIGN KEY(CAR_ID) REFERENCES CARS(ID));

CREATE TABLE CARS(
ID INT PRIMARY KEY NOT NULL,
BRAND TEXT NOT NULL,
MODEL TEXT NOT NULL,
YEAR INT,
COLOR TEXT,
LECTURER_ID INT,
FOREIGN KEY(lECTURER_ID) REFERENCES lECTURER(ID));
