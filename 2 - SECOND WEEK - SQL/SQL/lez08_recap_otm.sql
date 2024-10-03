CREATE DATABASE lez08_recap_otm
USE lez08_recap_otm

CREATE TABLE Persona(
	personaID INTEGER PRIMARY KEY IDENTITY, --la primary key è una struttura dati che serve ad ottimizzare le ricerche 
	nome VARCHAR(255) NOT NULL,
	cognome VARCHAR(255) NOT NULL,
	email VARCHAR(100) NOT NULL UNIQUE
)

CREATE TABLE Carta(
	cartaID INTEGER PRIMARY KEY IDENTITY,
	codice VARCHAR(255) NOT NULL UNIQUE, 
	negozio VARCHAR(255) NOT NULL,
	personaRIF INTEGER NOT NULL,
	FOREIGN KEY(personaRIF) REFERENCES Persona(personaID) ON DELETE CASCADE
)

INSERT INTO Persona (nome,cognome,email) VALUES
	('Giovanni','Pace','gio@pace.com'),
	('Valeria','Verdi','val@verdi.com'),
	('Marika','Mariko','mari@ka.com')

INSERT INTO Carta(codice,negozio,personaRIF) VALUES
	('AB123','MDio',1),
	('AB124','Conad',2),
	('AB125','Eurospina',3),
	('AB126','Mauryzius',1),
	('AB127','MDio',2),
	('AB128','Conad',3)

--TUTTE LE CARTE DI VALERIA
SELECT * 
	FROM Persona
	JOIN Carta ON Persona.personaID = Carta.personaRIF
	WHERE nome = 'Valeria' AND cognome = 'Verdi'

	
INSERT INTO Persona (nome,cognome,email) VALUES
	('Mario','Rossi','mar@ros.com')

--TUTTE LE CARTE POSSEDUTE DA QUALCUNO E QUELLE NON POSSEDUTE
SELECT * 
	FROM Persona --left
	LEFT JOIN Carta ON Persona.personaID = Carta.personaRIF

SELECT *
	FROM Carta
	RIGHT JOIN Persona ON Carta.cartaID = Persona.personaID


--SELEZIONA IL PROPRIETARIO DELLA CARTA AB125
SELECT * 
	FROM Carta --left
	JOIN Persona ON Carta.personaRIF = Persona.personaID
	WHERE codice = 'AB125'

SELECT nome,cognome,codice,negozio
	FROM Carta
	JOIN Persona ON Carta.personaRIF = Persona.personaID
	ORDER BY negozio ASC

SELECT nome,cognome,codice,negozio
	FROM Carta
	JOIN Persona ON Carta.personaRIF = Persona.personaID
	ORDER BY negozio,codice DESC

