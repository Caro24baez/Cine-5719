﻿using System;
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
        List<Entrada> obtenerEntradasParaCajero(Cajero cajero);
        void actualizarEntrada(Proyeccion proyeccion);
        #endregion

        #region Sala
        void agregarSala(Sala sala);
        List<Sala> obtenerSalas();
        #endregion

        #region Proyeccion
        void agregarProyeccion(Proyeccion proyeccion);
        List<Proyeccion> obtenerProyecciones();
        void actualizar(Proyeccion proyeccion);
        void actualizarProyeccion(Proyeccion proyeccion);
        List<Proyeccion> ProyeccionDe(Pelicula pelicula);
        #endregion

        #region Cajero
        void agregarCajero(Cajero cajero);
        Cajero cajeroPorMailyPass (string mail, string pass);
        List<Cajero> obtenerCajeros();
        #endregion

        #region PeliculaGenero
        void agregarPeliculaGenero(PeliculaGenero peliculaGenero);
        #endregion
    }
}
