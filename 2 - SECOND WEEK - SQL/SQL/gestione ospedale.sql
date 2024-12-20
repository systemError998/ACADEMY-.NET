
CREATE DATABASE gestione_ospedale
USE gestione_ospedale

CREATE TABLE Paziente(
	pazienteID INTEGER PRIMARY KEY IDENTITY,
	nominativo VARCHAR(255) NOT NULL,
	codice VARCHAR(255) NOT NULL UNIQUE
)

CREATE TABLE Reparto(
	repartoID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(255) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	piano VARCHAR(20) NOT NULL 
)

CREATE TABLE Medico(
	medicoID INTEGER PRIMARY KEY IDENTITY,
	nominativo VARCHAR(255) NOT NULL,
	identificativo VARCHAR(10) NOT NULL unique,
	repartoRIF INTEGER NOT NULL,
	FOREIGN KEY(repartoRIF) REFERENCES Reparto(repartoID) ON DELETE CASCADE
)

CREATE TABLE Esame(
	esameID INTEGER PRIMARY KEY IDENTITY,
	tipologia VARCHAR(255) NOT NULL,
	esito TEXT,
	pazienteRIF INTEGER NOT NULL,
	FOREIGN KEY(pazienteRIF) REFERENCES Paziente(pazienteID) ON DELETE CASCADE
)

CREATE TABLE Ricovero(
	ricoveroID INTEGER PRIMARY KEY IDENTITY,
	motivo TEXT,
	data_ingresso DATETIME DEFAULT CURRENT_TIMESTAMP,
	data_uscita DATETIME,
	pazienteRIF INT,
	FOREIGN KEY(pazienteRIF) REFERENCES Paziente(pazienteID) ON DELETE CASCADE,
	repartoRIF INT,
	FOREIGN KEY(repartoRIF) REFERENCES Reparto(repartoID) ON DELETE CASCADE
)

CREATE TABLE Visita(
	visitaID INTEGER PRIMARY KEY IDENTITY,
	note TEXT,
	data_visita DATETIME DEFAULT CURRENT_TIMESTAMP,
	pazienteRIF INT NOT NULL,
	FOREIGN KEY(pazienteRIF) REFERENCES Paziente(pazienteID), --se elimino il medico le sue visite vengono eliminate
	medicoRIF INT NOT NULL,
	FOREIGN KEY(medicoRIF) REFERENCES Medico(medicoID) ON DELETE CASCADE, --se elimino il medico le sue visite vengono eliminate
)

INSERT INTO Reparto (nome, numero, piano) VALUES 
('Cardiologia', 101, 1),
('Neurologia', 102, 1),
('Ortopedia', 201, 2),
('Ginecologia', 202, 2),
('Pediatria', 301, 3),
('Dermatologia', 302, 3),
('Oncologia', 401, 4),
('Chirurgia', 402, 4),
('Urologia', 501, 5),
('Otorinolaringoiatria', 502, 5);
 
INSERT INTO Paziente (nominativo, codice) VALUES
('Mario Rossi', 'PZ001'),
('Luigi Bianchi', 'PZ002'),
('Anna Verdi', 'PZ003'),
('Giulia Gialli', 'PZ004'),
('Paolo Neri', 'PZ005'),
('Elena Blu', 'PZ006'),
('Marco Viola', 'PZ007'),
('Sara Rosa', 'PZ008'),
('Alessandro Grigi', 'PZ009'),
('Francesca Celeste', 'PZ010');
 
INSERT INTO Ricovero (repartoRIF, pazienteRIF, motivo, data_ingresso, data_uscita) VALUES
(1, 1, 'Infarto acuto', 2024-09-10, 2024-09-20),
(2, 1, 'Ischemia cerebrale', 2024-09-11, NULL),
(3, 2, 'Frattura femore', 2024-09-15, 2024-09-25),
(4, 2, 'Gravidanza a rischio', 2024-09-12, NULL),
(5, 3, 'Polmonite pediatrica', 2024-09-13, 2024-09-20),
(6, 3, 'Psoriasi grave', 2024-09-14, NULL),
(7, 4, 'Chemioterapia', 2024-09-15, 2024-09-30),
(8, 4, 'Appendicectomia', 2024-09-16, NULL),
(9, 5, 'Prostatite', 2024-09-17, 2024-09-25),
(10, 5, 'Infezione alle orecchie', 2024-09-18, NULL);
 
INSERT INTO Medico (nominativo, identificativo, repartoRIF) VALUES
('Dr. Luca Conti', 1001, 1),
('Dr.ssa Marta Ricci', 1002, 2),
('Dr. Gianni Ferrari',  1003, 3),
('Dr.ssa Laura Fabbri',  1004, 4),
('Dr. Andrea Moretti', 005, 5),
('Dr.ssa Silvia Bruni',  1006, 6),
('Dr. Roberto Galli',  1007, 7),
('Dr.ssa Alessia Fontana',  1008, 8),
('Dr. Marco Leone',  1009, 9),
('Dr. Sara De Luca', 1010, 10);
 
SELECT * FROM Medico;
 
INSERT INTO Visita (medicoRIF, pazienteRIF, data_visita, note) VALUES
(1, 1, 2024-09-10, 'Controllo post-infarto'),
(2, 1, 2024-09-11, 'Esami neurologici in corso'),
(3, 2, 2024-09-15, 'Controllo frattura femore'),
(4, 2, 2024-09-12, 'Gravidanza in miglioramento'),
(5, 3, 2024-09-13, 'Polmonite sotto controllo'),
(6, 3, 2024-09-14, 'Psoriasi cronica in trattamento'),
(7, 4, 2024-09-15, 'Chemioterapia prima sessione'),
(8, 4, 2024-09-16, 'Visita post-appendicectomia'),
(9, 5, 2024-09-17, 'Prostatite migliorata'),
(10, 5, 2024-09-18, 'Orecchie migliorate');
 
INSERT INTO Esame (tipologia, esito, pazienteRIF) VALUES
('ECG', 'Normale', 1),
('Risonanza magnetica', 'Ischemia cerebrale riscontrata', 2),
('Radiografia', 'Frattura composta', 3),
('Ecografia', 'Gravidanza monitorata', 4),
('TAC toracica', 'Polmonite visibile', 5),
('Biopsia cutanea', 'Psoriasi in fase avanzata', 6),
('PET', 'Tumore in remissione', 7),
('TAC addominale', 'Appendicite acuta', 8),
('Esame urine', 'Prostatite diagnosticata', 9),
('Esame audiometrico', 'Perdita uditiva lieve', 10);



