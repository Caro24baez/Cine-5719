using System;
using System.Collections.Generic;
using System.Text;

namespace Cine.Ado
{
    public interface IADO
    {

        #region Pelicula
        void agregarPelicula(Pelicula pelicula);
        List<Pelicula> obtenerPeliculas();

        #endregion

        #region Genero
        void agregarGenero(Genero genero);
        List<Genero> obtenerGeneros();
        #endregion

        #region Entrada
        void agregarEntrada(Entrada entrada);
        void actualizarEntrada(Entrada entrada);
        List<Entrada> obtenerEntradas();
        List<Proyeccion> proyeccionDe(Entrada entrada);
        #endregion

        #region Sala
        void agregarSala(Sala sala);
        List<Sala> obtenerSala();
        #endregion

        #region Proyeccion
        void agregarProyeccion(Proyeccion proyeccion);
        List<Proyeccion> obtenerProyecciones();
        #endregion

    }
}
