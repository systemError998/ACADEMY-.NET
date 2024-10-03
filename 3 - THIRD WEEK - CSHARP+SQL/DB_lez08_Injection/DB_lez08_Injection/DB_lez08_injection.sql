CREATE DATABASE DB_lez08_injection
USE DB_lez08_injection

CREATE TABLE Utente(
	utenteID INT PRIMARY KEY IDENTITY,
	username VARCHAR(250) NOT NULL UNIQUE,
	passw VARCHAR(250) NOT NULL,
	ruolo VARCHAR(10) NOT NULL CHECK (ruolo IN('user','admin'))
)

INSERT INTO Utente (username, passw, ruolo) VALUES
('mario_rossi', 'password123', 'USER'),
('luca_bianchi', '123secure', 'USER'),
('giulia_verdi', 'giulia2021', 'ADMIN'),
('anna_neri', 'anna_secure1', 'USER'),
('francesco_ferrari', 'fferrari_password', 'ADMIN'),
('elisa_russo', 'elisa!pass', 'USER'),
('matteo_gialli', 'mattG#45', 'USER'),
('laura_marrone', 'lmarrone_pass', 'USER'),
('admin_super', 'superadminpassword', 'ADMIN'),
('giacomo_blu', 'blueGiacomo01', 'USER');
 
SELECT * FROM Utente;