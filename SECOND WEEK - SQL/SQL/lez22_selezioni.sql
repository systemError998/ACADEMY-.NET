CREATE DATABASE lez22_selezioni
USE lez22_selezioni

-- DDL
CREATE TABLE Impiegato (
    impiegatoID INT PRIMARY KEY IDENTITY(1,1),
    nome NVARCHAR(50) NOT NULL,
    cognome NVARCHAR(50) NOT NULL,
    compenso DECIMAL(10, 2),
	dipartimento NVARCHAR(250),
);

BEGIN TRANSACTION
	INSERT INTO Impiegato (nome, cognome, compenso, dipartimento)
	VALUES ('Mario', 'Rossi', 35000.00, 'Finanza');
	INSERT INTO Impiegato (nome, cognome, compenso, dipartimento)
	VALUES ('Luca', 'Bianchi', 45000.00, 'Marketing');
	INSERT INTO Impiegato (nome, cognome, compenso, dipartimento)
	VALUES ('Giulia', 'Verdi', 50000.00, 'Vendite');
COMMIT TRANSACTION;
 
INSERT INTO Impiegato (nome, cognome, compenso, dipartimento) VALUES
('Anna', 'Neri', 40000.00, 'Finanza'),
('Francesco', 'Blu', 60000.00, 'Vendite'),
('Valeria', 'Verdi', 80000.00, 'Marketing');
 
-- --------------------------------------------------------------------

-- VOGLIO TUTTI I DIPARTIMENTI NON RIPETUTI

SELECT DISTINCT dipartimento FROM Impiegato

--VOGLIO I PRIMI 3 IMPIEGATI IN ORDINE DI COMPENSO

SELECT TOP(3) *
	FROM Impiegato
	ORDER BY compenso DESC

SELECT *
	FROM Impiegato
	ORDER BY compenso --offset e fetch non posso applicarli se non c'è un'ordinamento predefinito (il TOP non ne ha bisogno) 
	OFFSET 2 ROWS --IL CURSORE PARTE DA dopo la seconda riga 
	FETCH FIRST 3 ROWS ONLY --dall'offset prende 3 row


