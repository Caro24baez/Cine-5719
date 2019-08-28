using System;
using System.Collections.Generic;
using System.Text;

namespace Cine.Ado
{
    public interface IADO
    {
<<<<<<< HEAD
     
=======
        #region Pelicula
        void agregarPelicula(Pelicula pelicula);
        List<Pelicula> obtenerPelicula();

        #endregion

        #region Genero
        void agregarGenero(Genero genero);
        List<Genero> obtenerGenero();
        #endregion

        #region Entrada
        void agregarEntrada(Entrada entrada);
        void actualizarEntrada(Entrada entrada);
        List<Entrada> obtenerEntrada();
        List<Proyeccion> proyeccionDe(Entrada entrada);
        #endregion

        #region Sala
        void agregarSala(Sala sala);
        List<Sala> obtenerSala();
        #endregion

        #region Proyeccion
        void agregarProyeccion(Proyeccion proyeccion);
        List<Proyeccion> obtenerProyeccion();
        #endregion
>>>>>>> 0a615e7092958db78254ea7e26fabe09cf66bc10
    }
}
