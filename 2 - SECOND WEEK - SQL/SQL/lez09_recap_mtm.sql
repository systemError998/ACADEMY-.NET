CREATE DATABASE lez09_recap_mtm
USE lez09_recap_mtm

CREATE TABLE Studente(
	studenteID INTEGER PRIMARY KEY IDENTITY,
	nominativo VARCHAR(255) NOT NULL,
	matricola VARCHAR(10) NOT NULL UNIQUE
)

CREATE TABLE Esame(
	esameID INTEGER PRIMARY KEY IDENTITY,
	titolo VARCHAR(150) NOT NULL,
	data_esame DATETIME NOT NULL,
	crediti INTEGER NOT NULL
)

CREATE TABLE Iscrizione(
	studenteRIF INTEGER NOT NULL,
	esameRIF INTEGER NOT NULL,
	FOREIGN KEY(studenteRIF) REFERENCES Studente(studenteID) ON DELETE CASCADE, --se cancello lo studente a cascata elimino iscrizione esame
	FOREIGN KEY(esameRIF) REFERENCES Esame(esameID),
	PRIMARY KEY(studenteRIF,esameRIF)  --INDICE DOPPIO. 
)

--DML
INSERT INTO Studente(nominativo,matricola) VALUES
	('Giovanni Pace', 'AB1234'),
	('Valeria Verdi', 'AB1235'),
	('Mario Rossi' , 'AB1236')

INSERT INTO Esame(titolo,data_esame,crediti) VALUES
	('Analisi I','2020-01-01 09:00',6),
	('Analisi II','2020-01-02 10:00',6),
	('Analisi I','2020-01-01 09:00',6),
	('Basi di dati','2020-01-02 14:00',6),
	('Programmazoine','2020-01-04 09:00',6)

INSERT INTO Iscrizione(studenteRIF, esameRIF) VALUES
	(1,	2),
	(1,	4),
	(2,	2),
	(2,	5),
	(1,	3),
	(2,	3);

SELECT * FROM Studente
SELECT * FROM Esame
SELECT * FROM Iscrizione


--TUTTI GLI ESAMI A CUI E' ISCRITTO GIOVANNI PACE
SELECT *
	FROM Studente 
	LEFT JOIN Iscrizione ON Studente.studenteID = Iscrizione.studenteRIF
	LEFT JOIN Esame ON Iscrizione.esameRIF = Esame.esameID
	WHERE nominativo = 'Giovanni Pace'

--VOGLIO SAPERE TUTTI GLI STUDENTI ISCRITTI ALL'ESAME DI PROGRAMMAZOINE
SELECT *
	FROM Esame 
	JOIN Iscrizione ON Esame.esameID = Iscrizione.esameRIF
	JOIN Studente ON Iscrizione.studenteRIF = Studente.studenteID
	WHERE titolo = 'Programmazoine'

--TUTTI GLI STUDENTI ISCRITTI AGLI ESAMI E QUELLI NON ISCRITTI
SELECT *
	FROM Studente 
	LEFT JOIN Iscrizione ON Studente.studenteID = Iscrizione.studenteRIF
	LEFT JOIN Esame ON Iscrizione.esameRIF = esameID

--TUTTI GLI ESAMI A CUI SONO ISCRITTI TUTTI GLI STUDENTI E GLI ESAMI SENZA ISCRIZIONI
SELECT *
	FROM Studente 
	RIGHT JOIN Iscrizione ON Studente.studenteID = Iscrizione.studenteRIF
	RIGHT JOIN Esame ON Iscrizione.esameRIF = esameID

--TUTTI GLI STUDENTI ISCRITTI AGLI ESAMI + STUDENTI NON ISCRITTI + ESAMI SENZA ISCRITTI
SELECT *
	FROM Studente 
	LEFT JOIN Iscrizione ON Studente.studenteID = Iscrizione.studenteRIF
	LEFT JOIN Esame ON Iscrizione.esameRIF = esameID
UNION --Unione di due query
	SELECT *
		FROM Studente 
		RIGHT JOIN Iscrizione ON Studente.studenteID = Iscrizione.studenteRIF
		RIGHT JOIN Esame ON Iscrizione.esameRIF = esameID

--TUTTI GLI ISCRITTI ALL'ESAME DI PROGRAMMAZIONE
SELECT *
	FROM Esame 
	JOIN Iscrizione ON Esame.esameID = Iscrizione.esameRIF
	JOIN Studente ON Iscrizione.studenteRIF = Studente.studenteID
	WHERE titolo = 'Programmazoine'
