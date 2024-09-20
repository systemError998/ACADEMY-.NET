CREATE DATABASE lez14_impiegati
USE lez14_impiegati

CREATE TABLE Impiegato(
	impiegatoID INT PRIMARY KEY IDENTITY,
	nome VARCHAR(255) NOT NULL,
	cognome VARCHAR(255) NOT NULL,
	email VARCHAR(255) NOT NULL,
	mansione VARCHAR(255) NOT NULL,
	dipartimento VARCHAR(255) NOT NULL,
	data_inizio DATE,
	salario DECIMAL(10,2)
)

INSERT INTO Impiegato(nome,cognome,email,mansione,dipartimento,data_inizio,salario) VALUES
('James', 'Smith', 'james.smith@example.com', 'Software Engineer', 'Engineering', '2019-03-01', 150000),
('Maria', 'Garcia', 'maria.garcia@example.com', 'Project Manager', 'Marketing', '2018-06-15', 150000),
('Robert', 'Johnson', 'robert.johnson@example.com', 'Database Administrator', 'IT', '2017-05-29', 120000),
('Patricia', 'Miller', 'patricia.miller@example.com', 'Product Manager', 'Sales', '2020-02-17', 60000),
('Michael', 'Davis', 'michael.davis@example.com', 'Web Developer', 'Engineering', '2021-08-23', 120000),
('Linda', 'Martinez', 'linda.martinez@example.com', 'Graphic Designer', 'Design', '2016-04-11', 150000),
('Elizabeth', 'Hernandez', 'elizabeth.hernandez@example.com', 'Sales Associate', 'Sales', '2019-07-19', 150000),
('William', 'Brown', 'william.brown@example.com', 'Systems Analyst', 'IT', '2018-09-03', 153000),
('Jennifer', 'Wilson', 'jennifer.wilson@example.com', 'Consultant', 'Customer Service', '2017-12-08', 154000),
('David', 'Anderson', 'david.anderson@example.com', 'Quality Assurance', 'Engineering', '2020-05-01', 78000),
('Susan', 'Thomas', 'susan.thomas@example.com', 'HR Specialist', 'Human Resources', '2018-03-23', 78000),
('Joseph', 'Moore', 'joseph.moore@example.com', 'Finance Analyst', 'Finance', '2019-11-30', 16000),
('Margaret', 'Taylor', 'margaret.taylor@example.com', 'Content Writer', 'Marketing', '2021-01-15', 78000),
('Charles', 'Lee', 'charles.lee@example.com', 'UX Designer', 'Design', '2017-07-09', 78000),
('Christopher', 'Harris', 'christopher.harris@example.com', 'Network Engineer', 'IT', '2018-08-21', 60000),
('Jessica', 'Clark', 'jessica.clark@example.com', 'Social Media Manager', 'Marketing', '2020-06-05', 60000),
('Daniel', 'Lewis', 'daniel.lewis@example.com', 'Business Analyst', 'Business Development', '2019-04-12', 20000),
('Sarah', 'Walker', 'sarah.walker@example.com', 'Recruiter', 'Human Resources', '2021-09-20', 60000),
('Thomas', 'Robinson', 'thomas.robinson@example.com', 'Technical Support', 'Customer Service', '2017-11-13', 64000),
('Nancy', 'Rodriguez', 'nancy.rodriguez@example.com', 'Legal Advisor', 'Legal', '2018-01-29', 61000);

SELECT * FROM Impiegato;

--CREAZIONE SP
CREATE PROCEDURE GetAllImpiegato AS 
BEGIN --{
	--CORPO
	SELECT * FROM Impiegato;
END   --}

--Eseguo la stored procedure
EXEC GetAllImpiegato

--Droppo la SP
DROP PROCEDURE GetAllImpiegato

--Modifica di una SP
ALTER PROCEDURE GetAllImpiegato AS
BEGIN
	SELECT * FROM Impiegato WHERE dipartimento = 'legal'
END   

--------------------------------------------------------------------------------------------------------

--Voglio una procedura che prenda il parametro dipartimento in modo dinamico e 
-- restituisca tutti gli impiegati afferenti a quel dipartimento

CREATE PROCEDURE GetImpiegatoByDipartimento 
	@NomeDipartimento VARCHAR(255)
AS 
BEGIN 
	SELECT * FROM Impiegato WHERE dipartimento = @NomeDipartimento
END

EXEC GetImpiegatoByDipartimento @NomeDipartimento = 'Engineering'

--------------------------------------------------------------------------------------------------------

-- SE definito il parametro dipartimento,
-- restituisci tutti gli impiegati afferenti, altrimenti tutti

CREATE PROCEDURE GetImpiegatoByDipartimentoOrAll 
	@NomeDipartimento VARCHAR(250) = NULL -- se non te lo specifico il valore di default è null
AS 
BEGIN
	IF @NomeDipartimento IS NULL 
		BEGIN
			SELECT * FROM Impiegato
		END
	ELSE
		BEGIN
			SELECT * FROM Impiegato WHERE dipartimento = @NomeDipartimento
		END
END

EXEC GetImpiegatoByDipartimentoOrAll --restituisce tutti gli impiegati (if)
EXEC GetImpiegatoByDipartimentoOrAll @NomeDipartimento = 'legal'

--------------------------------------------------------------------------------------------------------

-- Creare una SP che mi permetta di inserire un impiegato,
-- se non è specificato il dipartimento inserire stagista

CREATE PROCEDURE InsertImpiegato
	@Nome VARCHAR(250),
	@Cognome VARCHAR(250),
	@Email VARCHAR(250),
	@Mansione VARCHAR(250),
	@Dipartimento VARCHAR(250) = NULL
AS
BEGIN
	IF @Dipartimento IS NULL
		BEGIN
			INSERT INTO Impiegato(nome,cognome,email,mansione,dipartimento) VALUES
			(@Nome,@Cognome,@Email,@Mansione,'Stagista')
		END
	ELSE
		BEGIN
			INSERT INTO Impiegato(nome,cognome,email,mansione,dipartimento) VALUES
			(@Nome,@Cognome,@Email,@Mansione,@Dipartimento)
		END
END

DROP PROCEDURE InsertImpiegato

EXEC InsertImpiegato @Nome = 'Giovanni', @Cognome = 'Pace', @Email = 'gio@pax.com', @Mansione = 'prog'


--------------------------------------------------------------------------------------------------------
--REFACTORING

CREATE PROCEDURE InsertImpiegatoRefactor
	@Nome VARCHAR(250),
	@Cognome VARCHAR(250),
	@Email VARCHAR(250),
	@Mansione VARCHAR(250),
	@Dipartimento VARCHAR(250) = NULL,
	@Data DATE = NULL
AS
BEGIN
	IF @Dipartimento IS NULL
		BEGIN
			SET @Dipartimento = 'Stagista'
			SET @Data = CURRENT_TIMESTAMP
		END

		INSERT INTO Impiegato(nome,cognome,email,mansione,dipartimento) VALUES
		(@Nome,@Cognome,@Email,@Mansione,@Dipartimento)
	
END