-- CREATE DATABASE lez02_struttura;
USE lez01_introduzione;


-- DROP TABLE IF EXISTS Persona;
CREATE TABLE Persona(
	nome VARCHAR(250) NOT NULL, --NOT NULL INDICA CHE NON PUò ESSERE NULL
	cognome VARCHAR(250) NOT NULL,
	telefono VARCHAR(250),
	cod_fis CHAR(250) NOT NULL UNIQUE, --NO CAMEL CASE, E' CASE SENSITIVE / UNIQUE INDICA CHE QUESTO CAMPO SARA' UNIVOCO
	 email VARCHAR(250) -- => NON POSSO SOVRASCRIVERE UNA STRUTTURA GIA' ESISTENTE, QUINDI NON POSSO AGGIUNGERE CAMPI DOPO AVER CREATO LA TABELLA
	)

--ALTERARE LA TABELLA SENZA CANCELLARLA , AGGIUNGO UNA COLONNA
ALTER TABLE Persona ADD email VARCHAR(250) NOT NULL;

-- ELIMINA COLONNA
ALTER TABLE Persona DROP COLUMN email;

--MODIFICA UNA COLONNA
ALTER TABLE Persona ALTER COLUMN email VARCHAR(150);

--DML 
-- 1. in questo modo inserisco un record alla volta nel database, quindi se ci sono errori su alcuni record SOLO quel record non verrà inserito 
--INSERT INTO Persona(nome,cognome,telefono,cod_fis) VALUES
--	('Giovanni','Pace','3298765','GNNPCE')
--INSERT INTO Persona(nome,cognome,telefono,cod_fis) VALUES
--	('Valeria','Verdi','434423432','VRDVLR')
--INSERT INTO Persona(nome,cognome,telefono,cod_fis) VALUES
--	('Mario','Rossi','87654','MRORSS')
--INSERT INTO Persona(nome,cognome,telefono,cod_fis) VALUES
--	('Giovanna','Pace','3298765','GNNPCE')

-- 2. questo è tutto uno statement, quindi se c'è un errore non esegue nulla
INSERT INTO Persona(nome,cognome,telefono,cod_fis) VALUES
	('Giovanni','Pace','3298765','GNNPCE'),
	('Valeria','Verdi','434423432','VRDVLR'),
	('Mario','Rossi','87654','MRORSS'),
	('Giovanna','Pace','3298765','GNNPCA')

--QL
SELECT * FROM Persona;

--ELIMINAZIONE DATI
DELETE FROM Persona; --Cancella tutti i record dalla tabella

DELETE FROM Persona 
	WHERE cod_fis = 'GNNPCA' --Cancella tutta la riga

--MODIFICA DATI
UPDATE Persona SET 
	nome = 'Marika', 
	cognome = 'Mariko' 
	WHERE cod_fis = 'MRORSS'

--QL
--Proiezione
SELECT * FROM Persona; -- proietto su tutti 
SELECT nome, cod_fis FROM Persona; -- proietto su nome e cod fis (filtro verticale)
SELECT nome, cod_fis FROM Persona WHERE nome = 'Giovanni' --proiezione orizzontale

SELECT * FROM Persona 
	WHERE cod_fis = 'MRORSS'

