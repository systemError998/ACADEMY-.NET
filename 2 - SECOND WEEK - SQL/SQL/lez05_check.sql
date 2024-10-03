-- DDL
CREATE DATABASE lez05_check_negozio;
USE lez05_check_negozio

DROP TABLE IF EXISTS Prodotto
-- CHECK
CREATE TABLE Prodotto(
	prodottoID INTEGER IDENTITY,
	nome VARCHAR(255) NOT NULL,
	descrizione TEXT,   -- Blocco di memoria variabile VARCHAR
	categoria VARCHAR(50) DEFAULT 'Non definito',
	codice VARCHAR(10) NOT NULL,
	prezzo DECIMAL(5,2) CHECK (prezzo >= 0) ,  --(lunghezza massima, lunghezza della parte decimale) 
	data_scadenza DATE CHECK (data_scadenza BETWEEN '2000-01-01' AND '2100-01-01'),
	data_inserimento DATETIME DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY(prodottoID),
	UNIQUE(codice),
	-- CONSTRAINT CHK_Prezzo CHECK (prezzo >= 0), -- = CHECK (prezzo >= 0),
	-- CONSTRAINT CHK_DataScad CHECK (data_scadenza BETWEEN '2000-01-01' AND '2100-01-01')
)

-- ELIMINARE UN VINCOLO
ALTER TABLE Prodotto DROP CONSTRAINT CHK_Prezzo;

ALTER TABLE Prodotto 
	ADD CONSTRAINT CHK_Categoria
	CHECK(categoria IN ('Illuminazione','Alimento','Bricolage','Non definito'))

ALTER TABLE Prodotto 
	ADD CONSTRAINT CHK_Prezzo CHECK(prezzo>=0)