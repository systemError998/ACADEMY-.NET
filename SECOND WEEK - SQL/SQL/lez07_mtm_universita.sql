CREATE DATABASE lez07_mtm_universita
USE lez07_mtm_universita

CREATE TABLE Studente(
	studenteID INTEGER PRIMARY KEY IDENTITY,
	nominativo VARCHAR(100) NOT NULL,
	matricola VARCHAR(10) NOT NULL UNIQUE
)

CREATE TABLE Esame(
	esameID INTEGER PRIMARY KEY IDENTITY,
	titolo VARCHAR(255) NOT NULL,
	data_esame DATETIME NOT NULL,
	crediti INTEGER
)

CREATE TABLE Studente_Esame( --TABELLA ISCRIZIONI
	studenteRIF INTEGER NOT NULL,
	esameRIF INTEGER NOT NULL,
	FOREIGN KEY(studenteRIF) REFERENCES Studente(studenteID) ON DELETE CASCADE,
	FOREIGN KEY(esameRIF) REFERENCES Esame(esameID) ON DELETE CASCADE,
	PRIMARY KEY(studenteRIF,esameRIF) --La coppia studente esame è unica perchè non posso avere "due iscrizioni allo stesso esame"
)

