CREATE DATABASE lez10_oto_anagrafe
USE lez10_oto_anagrafe

CREATE TABLE Persona(
	personaID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(255) NOT NULL,
	cognome VARCHAR(255) NOT NULL
)

CREATE TABLE CodFis(
	codfisID INTEGER PRIMARY KEY IDENTITY,
	codice CHAR(16) NOT NULL UNIQUE,
	scadenza DATE NOT NULL,
	personaRIF INTEGER UNIQUE NOT NULL,
	FOREIGN KEY(personaRIF) REFERENCES Persona(personaID) ON DELETE CASCADE
)

INSERT INTO Persona(nome,cognome) VALUES
	('Giovanni','Pace'),
	('Valeria','Verdi')

INSERT INTO CodFis(codice,scadenza,personaRIF) VALUES
	('PCAGNN','2020-01-01',1),
	('VLRVRD','2020-01-01',2)

SELECT * FROM Persona
SELECT * FROM CodFis

SELECT *
	FROM Persona
	JOIN CodFis ON Persona.personaID = CodFis.personaRIF
	WHERE nome = 'Giovanni'