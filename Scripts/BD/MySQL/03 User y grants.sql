CREATE USER 'operador'@'10.120.0.%'
IDENTIFIED BY '0123456789';

GRANT SELECT ON Proyeccion TO 'operador'@'10.120.0.%';
GRANT SELECT ON Sala TO 'operador'@'10.120.0.%';
GRANT SELECT ON Pelicula TO 'operador'@'10.120.0.%';
GRANT SELECT ON PeliculaGenero TO 'operador'@'10.120.0.%';
GRANT SELECT ON Genero TO 'operador'@'10.120.0.%';
GRANT SELECT, INSERT ON Entrada TO 'operador'@'10.120.0.%';
