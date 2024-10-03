/*
Creare un sistema di gestione piatti di un ristorante.
Ogni piatto è caratterizzato da:
- Nome
- Descrizione
- Prezzo
- Se è vegan o no
- Se contiene glutine
- Categoria ("Primo", "Secondo", "Contorno)

Inserisci almeno 6 piatti e scrivere una query che:
- Restituisce tutti i piatti vegani
- Restituisce sia i piatti vegani che quelli senza glutine
- Restituisce i piatti vegani che costano meno di 20 euro
- Restituisce tutti i piatti vegani o senza glutine che costano meno di 15 Euro
- Restituisce tutti i piatti della categoria "Primi"
*/

CREATE DATABASE Menu_Ristorante
USE Menu_Ristorante

DROP TABLE IF EXISTS Piatti
CREATE TABLE Piatti(
	piattoID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(255) NOT NULL,
	descrizione TEXT,
	prezzo DECIMAL(5,2),
	CONSTRAINT CHK_Prezzo  CHECK (prezzo >=0),
	is_vegan BIT NOT NULL DEFAULT 0,
	has_glutine BIT NOT NULL DEFAULT 1, -- oppure TINYINT(1)
	categoria VARCHAR(20) NOT NULL CHECK (categoria IN('Primo', 'Secondo', 'Contorno'))
)

SELECT * FROM Piatti

INSERT INTO Piatti(nome,descrizione,prezzo,is_vegan,has_glutine,categoria) VALUES
	('Carbonara','Pasta con uova,guanciale e parmigiano',10,0,1,'Primo'),
	('Orecchiette con cime di rapa','delle orecchiette con delle cime di rapa',21.9,1,0,'Primo'),
	('Straccetti di pollo','straccetti di pollo con peperoni',13.9,0,0,'Secondo'),
	('Polpette di tofu','polpette con il tofu',7,1,0,'Secondo'),
	('Purè di broccolo','purea di broccolo',8,1,1,'Contorno'),
	('Gateau','gateau di patate e prosciutto cotto',20,0,1,'Contorno')

-- Restituisce tutti i piatti vegani

SELECT * FROM Piatti	
	WHERE is_vegan = 1;

-- Restituisce sia i piatti vegani che quelli senza glutine

SELECT * FROM PIATTI
	WHERE is_vegan = 1 OR has_glutine = 0

-- Restituisce i piatti vegani che costano meno di 20 euro

SELECT * FROM Piatti 
	WHERE is_vegan = 1 AND prezzo < 20

-- Restituisce tutti i piatti vegani o senza glutine che costano meno di 15 Euro

SELECT * FROM Piatti WHERE (is_vegan = 1 OR has_glutine = 0) AND prezzo < 15

-- Restituisce tutti i piatti della categoria "Primi"

SELECT * FROM Piatti WHERE categoria = 'Primo'