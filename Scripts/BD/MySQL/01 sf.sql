DELIMITER $$
CREATE FUNCTION entradasVendidasEn(unIdPelicula SMALLINT, fechaInferior DATETIME, fechaSuperior DATETIME) RETURNS INT

BEGIN 
	declare entrada INT;
    select count(idEntrada) into entrada
    from Entrada E
    where 

	return entrada;
END $$


DELIMITER $$
CREATE FUNCTION entradasDisponibles(unIdProyeccion SMALLINT)

BEGIN 



END$$ 