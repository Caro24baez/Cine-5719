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
            var menuListaGeneros = new MenuListaGeneros() { Nombre = "Lista Generos" };
            var menuListaPelicula = new MenuListaPelicula() { Nombre = "Lista Peliculas" };
            var menuAgregarGeneros = new MenuListaGeneros() { Nombre = "Agregar Genero" };
            var menuAgregarPelicula = new MenuListaPelicula() { Nombre = "Agregar Pelicula" };
            var menuModificarPrecioPelicula = new MenuModificarPrecioPelicula() { Nombre = "Modificar boleto" };

            var menupelicula = new MenuCompuesto() { Nombre = "Peliculas" };
            menupelicula.agregarMenu(menuListaPelicula);
            menupelicula.agregarMenu(menuAgregarPelicula);

            var menuGenero = new MenuCompuesto() { Nombre = "Generos" };
            menuGenero.agregarMenu(menuListaGeneros);
            menuGenero.agregarMenu(menuAgregarGeneros);

            var menuCajero = new MenuCompuesto() { Nombre = "Cajero" };
            menuCajero.agregarMenu(menuAltaCajero);
            menuCajero.agregarMenu(menuModificarPrecioPelicula);

            var menuprincial = new MenuCompuesto { Nombre = "Menu Administrador"};
            menuprincial.agregarMenu(menupelicula);
            menuprincial.agregarMenu(menuGenero);
            menuprincial.agregarMenu(menuCajero);

            

            menuprincial.mostrar();
        }
    }
}
