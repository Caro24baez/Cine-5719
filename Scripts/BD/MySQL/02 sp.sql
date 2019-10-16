DELIMITER $$
CREATE PROCEDURE unaProyeccion (unidProyeccion INT,
                                unidPelicula SMALLINT,
                                unidEntrada INT UNSIGNED,
                                unidSala TINYINT,
                                unaFechaHora DATETIME)
BEGIN
       INSERT INTO Proyeccion (idProyeccion, idPelicula, idSala, fechaHora)
       VALUES          (unaProyeccion, unidPelicula, unidSala, unaFechaHora);

END $$

DELIMITER $$
CREATE PROCEDURE unaPelicula (unidPelicula SMALLINT,
                              unNombre VARCHAR (45),
                              unaFechaLanzamiento DATETIME)
BEGIN 
      INSERT INTO Pelicula (idPelicula, nombre, fechaLanzamiento)
      VALUES        (unidPelicula, unNombre, unaFechaLanzamiento);

END $$

DELIMITER $$
CREATE PROCEDURE unaSala (unidSala TINYINT,
                          unPiso TINYINT,
                          unaCapacidad SMALLINT)
BEGIN 
      INSERT INTO Sala (idSala, piso, capacidad)
      VALUES           (unidSala, unPiso, unaCapacidad);
END $$

DELIMITER $$
CREATE PROCEDURE unGenero (unidGenero TINYINT,
                           unGenero TINYINT)
BEGIN 
      INSERT INTO Genero (idGenero, genero)
      VALUES             (unidGenero, unGenero);

END $$

DELIMITER $$
CREATE PROCEDURE unaPeliculaGenero (unidPelicula SMALLINT,
                                    unidGenero TINYINT)
BEGIN 
      INSERT INTO PeliculaGenero (idPelicula, idGenero)
      VALUES                      (unidPelicula, unidGenero);

END $$                                        