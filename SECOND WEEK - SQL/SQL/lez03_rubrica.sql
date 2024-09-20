CREATE DATABASE lez03_rubrica
USE lez03_rubrica

CREATE TABLE Contatto(
	contattoID INTEGER IDENTITY(1,1), --(1, è il numero da cui iniziare. 1, è l'incremento che deve avere)
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL,
	cod_fis CHAR(16) NOT NULL,
	UNIQUE(email),
	UNIQUE(cod_fis),
	PRIMARY KEY (contattoID)
)

--ID UNIVOCO

--DROP TABLE IF EXISTS Contatto
--CREATE TABLE Contatto(
--	contattoID INTEGER PRIMARY KEY IDENTITY(1,1), --(1, è il valore iniziale. 1, è il valore incrementale)
--	nome VARCHAR(250) NOT NULL,
--	cognome VARCHAR(250) NOT NULL,
--	email VARCHAR(250) NOT NULL UNIQUE,
--	cod_fis CHAR(16) NOT NULL UNIQUE
--)

--INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES 
--	('Giovanni','Pace','gio@pace.com','PCAGNN'),
--	('Valeria','Verdi','val@verd.com','VALVER'),
--	('Mario','Rossi','mar@ros.com','MARROS')

--DELETE FROM Contatto WHERE contattoID = 2;

--INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES  
--('Valeria','Verdi','val@verd.com','VALVER')
----OVVIAMENTE IL NUOVO ID SARA' 4 
--SELECT * FROM Contatto

INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
	('Giovanni', 'Pace', 'gio@pace.com', 'PCAGNN');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
	('Valeria', 'Verdi', 'val@verdi.com', 'VLRVRD');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
	('Mario', 'Rossi', 'mar@rossi.com', 'MARRSS');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
	('Marika', 'Mariko', 'mar@mar.com', 'MARMAR');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
	('Mario', 'Mariottide', 'mar@td.com', 'MARMTD');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
	('Maria', 'Mariani', 'mar@mrn.com', 'MARMRN');
INSERT INTO Contatto(nome, cognome, email, cod_fis) VALUES
	('Mariolino', 'Mariottide', 'mar@ted.com', 'MIOMTD');

--QL
SELECT * FROM Contatto

SELECT nome,cognome,email,cod_fis FROM Contatto

-- ALIAS
SELECT 
	nome AS 'Nome', 
	cognome AS 'cognome',
	email AS 'Indirizzo E-mail',
	cod_fis AS 'Codice Fiscale'
FROM Contatto;

--RICERCA 
SELECT * FROM Contatto 
	WHERE nome = 'Mario' AND cognome = 'Rossi';

SELECT * 
	FROM Contatto 
	WHERE nome = 'Mario' OR nome = 'Giovanni' OR nome = 'Marika';

SELECT * 
	FROM Contatto 
	WHERE nome IN ('Mario','Giovanni','Marika');

SELECT * 
	FROM Contatto 
	WHERE nome <> 'Mario' --  <> DIVERSO DA

--LIKE
SELECT * 
	FROM Contatto
	WHERE nome LIKE 'Ma%'   -- % SELEZIONA TUTTO CIO' CHE INIZIA PER MA

SELECT * 
	FROM Contatto
	WHERE nome LIKE '%io'   -- SELEZIONA TUTTO CIO' CHE FINISCE PER IO 

SELECT *
	FROM Contatto
	WHERE nome LIKE '%io%'   --SELEZIONA TUTTO CIO' CHE CONTIENE IO 

--RICERCA PUNTUALE
SELECT * 
	FROM Contatto
	WHERE nome LIKE 'Mari_'  -- IL NUMERO DI CARATTERI DEVE ESSERE PRECISO, troverà tutto ciò he ha 5 caratteri e inizia per MARI

SELECT * 
	FROM Contatto
	WHERE nome LIKE '__ri_'

	
 