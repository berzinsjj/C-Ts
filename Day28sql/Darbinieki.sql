CREATE DATABASE jaunaDB;

CREATE TABLE Klienti (
klientaID INT PRIMARY KEY AUTO_INCREMENT,
vards VARCHAR(20) NOT NULL,
uzvards VARCHAR(20) NOT NULL,
telefons INT NOT NULL,
epasts VARCHAR(30) NOT NULL
);

CREATE TABLE Darbinieki (
darbiniekaID INT PRIMARY KEY AUTO_INCREMENT,
vards VARCHAR(20) NOT NULL,
uzvards VARCHAR(20) NOT NULL,
epasts VARCHAR(30) NOT NULL
);

INSERT INTO Klienti (vards, uzvards, telefons, epasts)
VALUES ('Andris', 'Klavins', 4345346, 'dsfsdfsd@gmail.vol'),
		('Zintis', 'Liepa', 9898077, 'ttytuuh@ooop.com'),
        ('Anete', 'Klava', 22234809, 'ghfghgfh@cv.net'),
        ('Renars', 'Kazasola', 86564434, 'renchiiiks@zbb.oi'),
        ('Gints', 'Krams', 6664457, 'krams@iiii.ah'),
        ('Vladislavs', 'Lode', 97453253, 'iiioujujyu@uuu.lv');
        
INSERT INTO Darbinieki (vards, uzvards, epasts)
VALUES ('Krisjanis', 'Kraans', 'kraans@gmail.com'),
        ('Daniels', 'Plutka', 'plutka@inbox.lv');
        
        
CREATE TABLE Savienojums(
	klientaID INT NOT NULL,
    darbiniekaID INT NOT NULL,
	FOREIGN KEY (klientaID) REFERENCES Klienti(klientaID),
	FOREIGN KEY (darbiniekaID) REFERENCES Darbinieki(darbiniekaID)
);

INSERT INTO Savienojums(klientaID, darbiniekaID)
VALUES
	(1, 1),
    (2, 1),
    (3, 2),
    (4, 2),
    (5, 1),
    (5, 2),
    (6, 1),
    (6, 2);
    
SELECT * FROM Savienojums;

SELECT Klienti.vards, Klienti.uzvards, Darbinieki.vards
FROM Klienti
INNER JOIN Savienojums
ON Klienti.klientaID = Savienojums.klientaID
INNER JOIN Darbinieki
ON Darbinieki.darbiniekaID = Savienojums.darbiniekaID
WHERE Darbinieki.darbiniekaID = 1;






