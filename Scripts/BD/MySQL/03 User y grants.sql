Create USER 'Administrador'@'%'IDENTIFIED BY 'passadmin';
Create USER 'Usuario'@'%' IDENTIFIED BY 'passusuario';

Grant Select,Insert ON Pelicula TO 'Administrador'@'%';
Grant Select,Insert ON Genero TO 'Administrador'@'%';
Grant Select,Insert ON PeliculaGenero TO 'Administrador'@'%';
Grant Select,Insert ON Proyeccion TO 'Administrador'@'%';
Grant Select,Insert ON Sala TO 'Administrador'@'%';

Grant Select,Insert On Pelicula TO 'Usuario'@'%';
Grant Select,Insert ON Pelicula TO 'Usuario'@'%';
Grant Select,Insert ON Genero TO 'Usuario'@'%';
Grant Select,Insert ON Proyeccion TO 'Usuario'@'%';
Grant Select,Insert ON Sala TO 'Usuario'@'%';