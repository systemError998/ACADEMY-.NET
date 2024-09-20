CREATE DATABASE lez06_otm_carte;
USE lez06_otm_carte

DROP TABLE IF EXISTS Persona
CREATE TABLE Persona(
	personaID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(255) NOT NULL,
	cognome VARCHAR(255) NOT NULL,
	email VARCHAR(255)
)

DROP TABLE IF EXISTS Carta
CREATE TABLE Carta(
	cartaID INTEGER PRIMARY KEY IDENTITY,
	codice VARCHAR(10) NOT NULL UNIQUE,
	negozio VARCHAR(50) NOT NULL,
	personaRIF INTEGER NOT NULL,
	FOREIGN KEY(personaRIF) REFERENCES Persona(personaID) ON DELETE CASCADE
	-- la foreign key personaRIF ha come riferimento, sulla tabella persona, la colonna personaID
	--all'eliminazione della persona a cascata vanno eliminate anche le carte
)

INSERT INTO Persona(nome,cognome,email) VALUES
	('Giovanni','Pace','gio@pace.com'),
	('Valeria','Verdi','val@ver.com'),
	('Mario','Rossi','mar@rossi.com')

INSERT INTO Carta(codice,negozio,personaRIF) VALUES
	('AB1234','Coap',1),
	('AB1235','Coap',2),
	('AB1236','Eurospina',3),
	('AB1237','MDio',2),
	('AB1238','Conrad',3)

SELECT * FROM Persona
SELECT * FROM Carta

DELETE FROM Persona WHERE nome = 'Giovanni'

--JOIN su Persona

SELECT * 
	FROM Persona 
	JOIN Carta ON Persona.personaID = Carta.personaRIF
-- seleziona la tabella persona, unisci la tabella carta 
-- e il campo personaID della tabella Persona è uguale al campo personaRIF della tabella Carta
	WHERE personaID = 2

-- JOIN su Carta

SELECT nome,cognome,codice,negozio 
	FROM Carta
	JOIN Persona ON Carta.personaRIF = Persona.personaID
	WHERE cartaID = 3

--Aggiungo una persona che non ha carta
INSERT INTO Persona(nome,cognome,email) VALUES
	('Marika','Mariko','mrk@mrk.com')
SELECT * 
	FROM Persona 
	LEFT JOIN Carta ON Persona.personaID = Carta.personaRIF






