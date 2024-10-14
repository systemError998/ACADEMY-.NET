CREATE DATABASE lez17_sp_transaction
USE lez17_sp_transaction

DROP TABLE IF EXISTS Prodotto
DROP TABLE IF EXISTS Ordine

CREATE TABLE Prodotto(
	prodottoID INTEGER PRIMARY KEY IDENTITY,
	codice VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	nome VARCHAR(250) NOT NULL,
	quantita INTEGER CHECK (quantita > 0),
	quantita_dis INT CHECK (quantita_dis > 0)
)

CREATE TABLE Ordine(
	ordineID INTEGER PRIMARY KEY IDENTITY,
	codice VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	cliente VARCHAR(250) NOT NULL,
	prodottoRIF INTEGER NOT NULL, --not null perchè non esiste un ordine senza prodotto
	quantita_ord INT NOT NULL CHECK (quantita_ord > 0) ,
	FOREIGN KEY(prodottoRIF) REFERENCES Prodotto(prodottoID) ON DELETE CASCADE
)

INSERT INTO Prodotto(nome,quantita_dis) VALUES
	('Tavolo', 51),
	('Sedia', 12),
	('Lampada', 14)

CREATE PROCEDURE CreateOrdine
	@varNominativo VARCHAR(250),
	@varNomeProdotto VARCHAR(250),
	@varQuantita INTEGER
AS
BEGIN
	BEGIN TRY
		 BEGIN TRANSACTION
			IF @varQuantita < 0
				THROW 50001, 'Quantita non consentita',1

			UPDATE Prodotto	
				SET quantita_dis = quantita_dis - @varQuantita
				WHERE nome = @varNomeProdotto 
			IF @@ROWCOUNT = 0
				THROW 50001, 'errore, prodotto non trovato o quantità troppo elevata',1

			INSERT INTO Ordine(cliente, prodottoRIF, quantita_ord) VALUES
				(@varNominativo, @varQuantita, (SELECT prodottoID FROM Prodotto WHERE nome = @varNomeProdotto))--subquery per recuperare l'id because abbiamo il nome invece che l'id 
			IF @@ROWCOUNT = 0
				THROW 50001, 'errore, inserimento non riuscito',1

			PRINT 'stappo'
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		PRINT ERROR_MESSAGE()
	END CATCH
END

EXEC CreateOrdine @varNominativo = 'Giovanni', @varNomeProdotto = 'Lampada' , @varQuantita = 1