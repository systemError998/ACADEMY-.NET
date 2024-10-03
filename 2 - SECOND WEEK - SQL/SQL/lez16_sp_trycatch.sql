-- DDL
DROP TABLE IF EXISTS Impiegato;
CREATE TABLE Impiegato(
	impiegatoID INTEGER PRIMARY KEY IDENTITY,
	codice VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	nome VARCHAR(250) NOT NULL,
	cognome VARCHAR(250) NOT NULL,
	compenso DECIMAL(10,2) 
)

SELECT NEWID(); --Per vedere cosa restituisce una funzione sql ^^

--DML
INSERT INTO Impiegato(nome,cognome,compenso) VALUES
	('Giovanni','Pace',1000),
	('Valeria','Verdi',1200),
	('Marika','Mariko',1300)

--QL
SELECT * FROM Impiegato

SELECT impiegatoID FROM Impiegato WHERE codice = '4EFD24D2-9AC9-40A6-8D67-D272C598FA35'
--SUBQUERY
DELETE FROM Impiegato WHERE impiegatoID = (
	SELECT impiegatoID FROM Impiegato WHERE codice = '4EFD24D2-9AC9-40A6-8D67-D272C598FA35'
)

--MODIFICA IL SALARIO DI UNA PERSONA TRAMITE IL SUO CODICE,
--ATTENZIONE AI NUMERI NEGATIVI

CREATE PROCEDURE UpdateCompensoByCodice
	@varCodice VARCHAR(250) NOT NULL,
	@varCompenso DECIMAL(10,2)
AS
BEGIN
	BEGIN TRY
		IF @varCompenso < 0 
			THROW 50002, 'Salario negativo, non valido',1

		UPDATE Impiegato
		SET compenso = @varCompenso
		WHERE codice = @varCodice

		IF @@ROWCOUNT = 0 --conta il numero di righe coinvolte, quindi se le righe sono 0 il try non è andato a buon fine 
			THROW 50001, 'Non ho trovato questo impiegato',1

		PRINT 'Istruzione eseguita con successo'

	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE() --ERROR_CODE restituisce il codice di errore, ERROR_PRIORITY restituisce il codice di priorità
	END CATCH
END
	


