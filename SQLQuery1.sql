CREATE DATABASE DomaciADO;

USE DomaciADO;

CREATE TABLE Osoba
(
	ID INT IDENTITY(1,1),
	Ime NVARCHAR(15),
	Prezime NVARCHAR(15),
	JMBG NVARCHAR(13),
	Adresa NVARCHAR(30),
	Imejl NVARCHAR(30)	
)