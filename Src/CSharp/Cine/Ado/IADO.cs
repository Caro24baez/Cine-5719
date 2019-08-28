using System;
using System.Collections.Generic;
using System.Text;

namespace Cine.Ado
{
    public interface IADO
    {
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
    }
}
