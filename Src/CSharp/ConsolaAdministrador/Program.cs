using System;
using MenuesConsola;
using ConsolaAdministrador.Menu;

namespace ConsolaAdministrador
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menuAltaCajero = new MenuAltaCajero() { Nombre = "Alta Cajero" };
            menuAltaCajero.mostrar();
            var menuListaGeneros = new MenuListaGeneros() { Nombre = "Generos" };
            menuListaGeneros.mostrar();
            var menuListaPelicula = new MenuListaPelicula() { Nombre = "Pelicula" };
            menuListaPelicula.mostrar();
        }
    }
}
