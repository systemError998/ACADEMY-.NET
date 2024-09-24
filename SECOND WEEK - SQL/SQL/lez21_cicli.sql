CREATE DATABASE lez21_cicli
USE lez21_cicli
-- DDL
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Salary DECIMAL(10, 2)
);

-- DML
INSERT INTO Employees(FirstName, LastName, Salary) VALUES
('Giovanni', 'Pace', 100000),
('Valeria', 'Verdi', 120000),
('Mario', 'Rossi', 90000);
 
SELECT * FROM Employees;

DECLARE EmployeeCursor CURSOR FOR  --Il cursore è un elemento che seleziona ogni singola riga
	SELECT FirstName + LastName, Salary FROM Employees

OPEN EmployeeCursor
	
	DECLARE @nominativo VARCHAR(250) 
	DECLARE @salario DECIMAL(10, 2)

	FETCH NEXT FROM EmployeeCursor INTO @nominativo,@salario --questa fetch ci serve per entrare nel primo elemento***

	WHILE @@FETCH_STATUS = 0 --LE KEYWORD CHE INIZIANO PER @@ SONO DELLE FUNZIONALITA' INTERNE DI SQL
	BEGIN
		PRINT 'Ho selezionato: ' + @nominativo + ' con salario ' + CAST(@salario AS VARCHAR)
		FETCH NEXT FROM EmployeeCursor INTO @nominativo,@salario --questa fetch invece ci serve per ciclare (i++) ***
	END

CLOSE EmployeeCursor