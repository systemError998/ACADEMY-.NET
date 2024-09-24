CREATE DATABASE lez18_variabili
USE lez18_variabili

DECLARE @variabile VARCHAR(250) = 'Giovanni'    --dichiarazione
PRINT @variabile    --stampa in console il contenuto della variabile
SELECT @variabile   --stampa il contenuto in una struttura tabellare 

--------------------------------------------------------------------

DECLARE @variabileUno VARCHAR(250);
DECLARE @variabileDue INTEGER;
DECLARE @variabileTre INTEGER;

SET @variabileUno = 'Giovanni'
SET @variabileDue = 5
SET @variabileTre = 8;

SELECT (@variabileUno + ' ha ' + CAST(@variabileDue + @variabileTre  AS VARCHAR) + ' anni') AS 'TEST'


