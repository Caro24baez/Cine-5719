DROP DATABASE IF EXISTS Cine;
CREATE DATABASE Cine;
USE Cine;

SET FOREIGN_KEY_CHECKS=0;

CREATE TABLE PeliculaGenero
(
	idPelicula SMALLINT NOT NULL,
	idGenero TINYINT NOT NULL,
	KEY (idGenero)
) 
;


CREATE TABLE Genero
(
	idGenero TINYINT NOT NULL,
	genero TINYINT NOT NULL,
	PRIMARY KEY (idGenero)
) 
;


CREATE TABLE Entrada
(
	idEntrada INTEGER NOT NULL,
	numeroEntrada INTEGER NOT NULL,
	funcion VARCHAR(45) NOT NULL,
	valor INTEGER NOT NULL,
	PRIMARY KEY (idEntrada)
) 
;


CREATE TABLE Sala
(
	idSala TINYINT NOT NULL,
	piso TINYINT NOT NULL,
	capacidad SMALLINT NOT NULL,
	PRIMARY KEY (idSala)
) 
;


CREATE TABLE Proyeccion
(
	idProyeccion SMALLINT NOT NULL,
	idPelicula SMALLINT NOT NULL,
	fechaHora DATETIME NOT NULL,
	idSala TINYINT NOT NULL,
	idEntrada INTEGER NOT NULL,
	PRIMARY KEY (idProyeccion),
	KEY (idEntrada),
	KEY (idPelicula)
) 
;


CREATE TABLE Pelicula
(
	idPelicula SMALLINT NOT NULL,
	nombre VARCHAR(45) NOT NULL,
	fechaLanzamiento DATETIME NOT NULL,
	PRIMARY KEY (idPelicula)
) 
;

CREATE TABLE  Cajero
(
	idCajero SMALLINT NOT NULL,
    nombre VARCHAR(45) NOT NULL,
    apellido VARCHAR(45) NOT NULL,
    email VARCHAR(45) NOT NULL,
    contraseña VARCHAR(45) NOT NULL,
    PRIMARY KEY (idCajero),
    KEY (idEntrada)
);

ALTER TABLE PeliculaGenero ADD CONSTRAINT FK_PeliculaGenero_Genero 
	FOREIGN KEY (idGenero) REFERENCES Genero (idGenero)
;

ALTER TABLE Proyeccion ADD CONSTRAINT FK_Proyeccion_Entrada 
	FOREIGN KEY (idEntrada) REFERENCES Entrada (idEntrada)
;

ALTER TABLE Proyeccion ADD CONSTRAINT FK_Proyeccion_Pelicula 
	FOREIGN KEY (idPelicula) REFERENCES Pelicula (idPelicula)
;
