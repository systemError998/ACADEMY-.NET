--DATA DEFINITION LANGUAGE ddl

CREATE DATABASE lez01_introduzione; /*Crea il db */
-- DROP DATABASE lez01_introduzione; /* Cancella il db */

USE lez01_introduzione; /* Selezioniamo il db */ 

--CREATE TABLE Persona(
	--nome VARCHAR(250) NOT NULL, --NOT NULL INDICA CHE NON PUò ESSERE NULL
	--cognome VARCHAR(250) NOT NULL,
	--telefono VARCHAR(250),
	--cod_fis CHAR(250) NOT NULL UNIQUE, --NO CAMEL CASE, E' CASE SENSITIVE / UNIQUE INDICA CHE QUESTO CAMPO SARA' UNIVOCO
	-- email VARCHAR(250) => NON POSSO SOVRASCRIVERE UNA STRUTTURA GIA' ESISTENTE, QUINDI NON POSSO AGGIUNGERE CAMPI DOPO AVER CREATO LA TABELLA
	--)

-- DROP TABLE Persona;

CREATE TABLE Persona(
	nome VARCHAR(250) NOT NULL, 
	cognome VARCHAR(250) NOT NULL,
	telefono VARCHAR(250),
	cod_fis CHAR(16) NOT NULL UNIQUE, 
	email VARCHAR(250) 
	)


--DATA MANIPULATION LANGUAGE dml
INSERT INTO Persona(nome,cognome,telefono,cod_fis,email) VALUES
	('Giovanni','Pace','123456','PCAGNN','gio@pace.it')
INSERT INTO Persona(nome,cognome,telefono,cod_fis,email) VALUES
	('Valeria','Verdi','254234','VRDVLR','vale@verdi.it')
INSERT INTO Persona(nome,cognome,cod_fis) VALUES
	('Mario','Rossi','MRORSS')
-- QL
SELECT * FROM Persona;