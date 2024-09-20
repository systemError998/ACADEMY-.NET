--# Progetazione e realizzazione:

--Progetazione Sistema di Gestone Alberghi
--La catena alberghiera "Sogni D'oro" necessita di un sistema di gestone delle prenotazioni per gestre le sue diverse struture sparse in tuto il paese. 
--Ogni albergo si distngue per nome, indirizzo, e valutazione (espressa in stelle). 
--All'interno di ogni albergo, vi sono diverse camere, ognuna caraterizzata da un numero unico per albergo, un tpo (singola, doppia, suite, ecc.), 
--una capacità massima di ospit e una tariffa per note.
--I client possono prenotare camere scegliendo specifiche date di check-in e check-out. 
--Ogni prenotazione riguarda una sola camera in un determinato periodo, e il sistema deve tenere traccia dell'identtà del cliente, 
--che include detagli come nome, cognome, e contato. Si noti che un cliente può effetuare più prenotazioni nel tempo, 
--ma una camera può essere prenotata solo da un cliente alla volta per qualsiasi data.
--Inoltre, l'albergo impiega diversi dipendent, inclusi receptonist, personale di pulizia e manager. 
--Ogni dipendente è associato a un unico albergo e ha un ruolo specifico nell'organizzazione. 
--È importante tracciare anche i detagli del dipendente, inclusi nome, cognome, posizione, e detagli del contato.
--Il sistema dovrebbe anche consentre la gestone delle facilites offerte da ogni albergo, come palestre, piscine o spa. 
--Ogni facility è caraterizzata da un nome, una descrizione e un insieme di orari di apertura.
--Si richiede di progetare uno schema ER per questo sistema, identficando chiaramente entità, atributi, e relazioni.

CREATE DATABASE catena_alberghiera
USE catena_alberghiera

CREATE TABLE Albergo(
	albergoID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(255) NOT NULL,
	indirizzo VARCHAR(255) NOT NULL,
	valutazione INTEGER CHECK(valutazione<=5) NOT NULL
)

CREATE TABLE Dipendente(
	dipendenteID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(255) NOT NULL,
	cognome VARCHAR(255) NOT NULL,
	ruolo VARCHAR(20) NOT NULL CHECK (ruolo IN('pulizia', 'receptionist', 'manager')),
	dettagli_contatto VARCHAR(255) NOT NULL,
	albergoRIF INT,
	FOREIGN KEY(albergoRIF) REFERENCES Albergo(albergoID)
)

CREATE TABLE Camera(
	cameraID INTEGER PRIMARY KEY IDENTITY,
	numero_unico INTEGER NOT NULL,
	tipo VARCHAR(20) NOT NULL CHECK (tipo IN('singola', 'matrimoniale', 'suite')),
	capa INTEGER NOT NULL CHECK(capa>0),
	tariffa DECIMAL(5,2),
	albergoRIF INT NOT NULL,
	FOREIGN KEY(albergoRIF) REFERENCES Albergo(albergoID) ON DELETE CASCADE, --se cancello albergo cancello a cascata anche la camera
	UNIQUE(albergoRIF,numero_unico)
)

CREATE TABLE Cliente(
	clienteID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(255) NOT NULL,
	cognome VARCHAR(255) NOT NULL,
	contatto VARCHAR(255) NOT NULL
)

CREATE TABLE Prenotazione(
	prenotazioneID INTEGER PRIMARY KEY IDENTITY,
	check_in DATE NOT NULL,
	check_out DATE NOT NULL,
	clienteRIF INTEGER NOT NULL,
	FOREIGN KEY(clienteRIF) REFERENCES Cliente(clienteID) ON DELETE CASCADE,
	cameraRIF INTEGER NOT NULL,
	FOREIGN KEY(cameraRIF) REFERENCES Camera(cameraID) ON DELETE CASCADE
)

ALTER TABLE Prenotazione ADD CONSTRAINT CHK__Data CHECK (check_out > check_in)

INSERT INTO Albergo (nome, indirizzo, valutazione) VALUES 
('Hotel Paradiso', 'Via Roma, 10', 2),
('Hotel Bellavista', 'Via Milano, 45', 3),
('Hotel Mareblu', 'Corso Italia, 22', 4),
('Hotel Sole', 'Piazza del Popolo, 5', 2),
('Hotel Luna', 'Via dei Fiori, 7', 2),
('Hotel Aurora', 'Viale dei Tigli, 12', 3),
('Hotel Stella', 'Via Verdi, 18', 5),
('Hotel Lago', 'Via del Mare, 55', 4),
('Hotel Montagna', 'Via Monti, 2', 3),
('Hotel Oasi', 'Via Alberi, 1', 5);
 
INSERT INTO Cliente (nome, cognome, contatto) VALUES
('Mario', 'Rossi', '1234567890'),
('Luigi', 'Bianchi', '0987654321'),
('Anna', 'Verdi', '1122334455'),
('Paolo', 'Neri', '6677889900'),
('Giulia', 'Blu', '4455667788'),
('Elena', 'Gialli', '9988776655'),
('Alessandro', 'Grigi', '3344556677'),
('Marco', 'Viola', '5566778899'),
('Francesca', 'Rosa', '1231231234'),
('Sara', 'Marroni', '9876543210');
 
INSERT INTO Camera (numero_unico, tipo, capa, tariffa, albergoRIF) VALUES
('101', 'suite', 4, 300.00, 1),
('102', 'matrimoniale', 2, 150.00, 1),
('103', 'singola', 1, 80.00, 1),
('201', 'suite', 4, 280.00, 2),
('202', 'matrimoniale', 2, 140.00, 2),
('301', 'singola', 1, 75.00, 3),
('401', 'suite', 4, 290.00, 4),
('501', 'matrimoniale', 2, 130.00, 5),
('601', 'singola', 1, 70.00, 6),
('701', 'matrimoniale', 2, 120.00, 7);
 
INSERT INTO Prenotazione (check_in, check_out, clienteRIF, cameraRIF) VALUES
('2024-09-10', '2024-09-15', 1, 1),
('2024-09-12', '2024-09-18', 2, 2),
('2024-09-14', '2024-09-20', 3, 3),
('2024-09-15', '2024-09-19', 4, 4),
('2024-09-16', '2024-09-21', 5, 5),
('2024-09-18', '2024-09-22', 6, 6),
('2024-09-19', '2024-09-23', 7, 7),
('2024-09-20', '2024-09-24', 8, 8),
('2024-09-21', '2024-09-25', 9, 9),
('2024-09-22', '2024-09-27', 10, 10);
 
INSERT INTO Prenotazione (chin, chou, clienteRIF, cameraRIF) VALUES
('2024-09-23', '2024-09-28', 1, 4),
('2024-09-24', '2024-09-29', 2, 5),
('2024-09-25', '2024-09-30', 3, 6),
('2024-09-26', '2024-10-01', 4, 7),
('2024-09-27', '2024-10-02', 5, 8),
('2024-09-28', '2024-10-03', 6, 9),
('2024-09-29', '2024-10-04', 7, 10),
('2024-09-30', '2024-10-05', 8, 1),
('2024-10-01', '2024-10-06', 9, 2),
('2024-10-02', '2024-10-07', 10, 3);

CREATE VIEW AgendaClienti AS
SELECT Cliente.nome,cognome,contatto,check_in,check_out,numero_unico, tipo, capa, tariffa, Albergo.nome AS NomeAlbergo, indirizzo, valutazione
	FROM Cliente
	JOIN Prenotazione ON Cliente.clienteID = Prenotazione.clienteRIF
	JOIN Camera ON Prenotazione.cameraRIF = Camera.cameraID
	JOIN Albergo ON Camera.albergoRIF = Albergo.albergoID

--Seleziono la vista e la leggo
SELECT * 
	FROM AgendaClienti
