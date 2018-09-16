CREATE DATABASE PrimerParcialDb
GO
USE PrimerParcialDb
GO
CREATE TABLE Articulos
(
ID int primary key identity,
Descripcion varchar(60),
Precio decimal,
Cantidadd int,
FechaDeVencimiento datetime
)