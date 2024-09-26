CREATE DATABASE lez06_task_edicola
USE lez06_task_edicola

CREATE TABLE Giocattolo(
	giocattoloID INTEGER PRIMARY KEY IDENTITY,
	codice VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	nome VARCHAR(250) NOT NULL,
	materiale VARCHAR(250) NOT NULL,
	eta_minima INTEGER NOT NULL,
	prezzo DECIMAL(5,2) NOT NULL
)

CREATE TABLE Rivista(
	rivistaID INTEGER PRIMARY KEY IDENTITY,
	codice VARCHAR(250) NOT NULL DEFAULT NEWID() UNIQUE,
	titolo VARCHAR(250) NOT NULL,
	casa_editrice VARCHAR(250) NOT NULL,
	prezzo DECIMAL(5,2) NOT NULL
)

INSERT INTO Giocattolo (nome, materiale, eta_minima, prezzo) VALUES 
('Macchinina', 'Plastica', 3, 9.99),
('Peluche Orsetto', 'Tessuto', 0, 14.50),
('Costruzioni', 'Plastica', 5, 24.90),
('Puzzle 1000 Pezzi', 'Cartone', 8, 19.99),
('Bambola', 'Vinile', 4, 12.75),
('Trenino Elettrico', 'Metallo', 6, 49.90),
('Palla Rimbalzante', 'Gomma', 3, 5.99),
('Action Figure', 'Plastica', 7, 18.75),
('Set da Disegno', 'Legno e Carta', 4, 10.50),
('Monopattino', 'Alluminio', 5, 29.99);

INSERT INTO Rivista (titolo, casa_editrice, prezzo) VALUES 
('Scienza per Tutti', 'Editrice Italiana', 4.99),
('Avventure del Passato', 'Storia Viva', 6.50),
('Giochi e Passatempi', 'Tempo Libero', 3.75),
('Cucina Facile', 'Gusto e Sapori', 5.99),
('Tecnologia Oggi', 'Futuro Tech', 7.25),
('Viaggi e Avventure', 'Mondo Viaggi', 6.99),
('Fitness e Benessere', 'Salute Attiva', 4.50),
('Moda e Stile', 'Fashion World', 5.20),
('Arte Contemporanea', 'Museo di Arte', 7.80),
('Auto e Motori', 'Velocità Magazine', 8.50);
