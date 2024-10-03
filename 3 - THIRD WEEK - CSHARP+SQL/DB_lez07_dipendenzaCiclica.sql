CREATE TABLE Albergo(
	albergoID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(250) NOT NULL,
	indirizzo VARCHAR(250) NOT NULL,
	stelle INT NOT NULL DEFAULT 3 CHECK(stelle BETWEEN 1 AND 5)
)

CREATE TABLE Camera(
	cameraID INTEGER PRIMARY KEY IDENTITY,
	codice VARCHAR(250) NOT NULL,
	posti INTEGER DEFAULT 1, 
	descrizione TEXT,
	albergoRIF INTEGER NOT NULL, -- (non esiste una camera senza un albergo)
	FOREIGN KEY(albergoRIF) REFERENCES Albergo(albergoID) ON DELETE CASCADE, -- se cancello l'albergo ovviamente cancello anche la camera
	UNIQUE(albergoRIF, codice)
)

INSERT INTO Albergo (nome, indirizzo, stelle)
VALUES
('Hotel Sole', 'Via Roma, 12', 4),
('Hotel Luna', 'Piazza delle Stelle, 45', 5),
('Albergo Mare', 'Lungomare, 10', 3),
('Hotel Montagna', 'Viale delle Alpi, 23', 4),
('B&B La Collina', 'Via Collina Verde, 15', 2),
('Hotel Paradiso', 'Corso Vittorio, 101', 5),
('Albergo Stelle', 'Via Centrale, 8', 3),
('Pensione Il Girasole', 'Via del Campo, 56', 1),
('Hotel Sole Blu', 'Piazza Marina, 18', 3),
('B&B Aurora', 'Via dell Aurora, 99', 2);

INSERT INTO Camera (codice, posti, descrizione, albergoRIF)
VALUES
('CAM001', 2, 'Camera matrimoniale con vista mare', 1),
('CAM002', 1, 'Camera singola con balcone', 1),
('CAM101', 4, 'Suite con jacuzzi', 2),
('CAM102', 3, 'Camera tripla con vista città', 2),
('CAM201', 1, 'Camera singola vista montagna', 4),
('CAM202', 2, 'Camera doppia vista mare', 3),
('CAM301', 3, 'Camera tripla con terrazza', 5),
('CAM302', 1, 'Camera singola economica', 6),
('CAM303', 2, 'Camera matrimoniale standard', 7),
('CAM401', 4, 'Camera familiare con 4 posti letto', 8);


SELECT * 
	FROM Albergo
	JOIN Camera ON Albergo.albergoID = Camera.albergoRIF
	WHERE nome = 'Hotel Sole'