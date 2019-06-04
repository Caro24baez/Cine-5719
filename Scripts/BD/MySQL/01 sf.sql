DELIMITER $$ 
CREATE FUNCTION entradasVendidasEntre (unidPelicula SMALLINT, fechaInferior DATETIME, fechaSuperior DATETIME) 
									RETURNS INT

BEGIN 
	DECLARE entrada INT;
    
    SELECT count(idEntrada) INTO entrada
    FROM Proyeccion  
    WHERE idPelicula = unidPelicula
    AND fechaHora BETWEEN fechaInferior AND fechaSuperior;
    
    
	RETURN entrada;
END $$




DELIMITER $$
CREATE FUNCTION entradasDisponibles(unIdProyeccion SMALLINT)
								RETURNS INT

BEGIN 
	DECLARE entradaDisponible INT;
    
    SELECT (capacidadSala - cantidadEntradasVendidas) INTO entradaDisponible
    FROM Proyeccion P
    INNER JOIN Entrada E
		ON P.idEntrada = E.idEntrada
	INNER JOIN Sala S
		ON S.idSala = P.idSala
	WHERE idProyeccion = unidProyeccion;
    
    RETURN entradaDisponible;

END $$ 