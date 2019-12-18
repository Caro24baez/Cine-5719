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
            var menuListaSala = new MenuListaSala() { Nombre = "Lista Salas" };
            var menuAgregarGeneros = new MenuAgregarGenero (menuListaGeneros) { Nombre = "Agregar Genero" };
            var menuAgregarPelicula = new MenuAgregarPelicula(menuListaPelicula) { Nombre = "Agregar Pelicula" };
            var menuAgregarSala = new MenuAgregarSala() { Nombre = "Agregar Sala" };
            var menuModificarPrecioPelicula = new MenuModificarPrecioPelicula() { Nombre = "Modificar Precio de la Pelicula" };

            var menupelicula = new MenuCompuesto() { Nombre = "Peliculas" };
            menupelicula.agregarMenu(menuListaPelicula);
            menupelicula.agregarMenu(menuAgregarPelicula);

            var menuGenero = new MenuCompuesto() { Nombre = "Generos" };
            menuGenero.agregarMenu(menuListaGeneros);
            menuGenero.agregarMenu(menuAgregarGeneros);

            var menuCajero = new MenuCompuesto() { Nombre = "Cajero" };
            menuCajero.agregarMenu(menuAltaCajero);
            menuCajero.agregarMenu(menuModificarPrecioPelicula);

            var menuSala = new MenuCompuesto() { Nombre = "Sala" };
            menuSala.agregarMenu(menuListaSala);
            menuSala.agregarMenu(menuAgregarSala);
            

            var menuprincial = new MenuCompuesto { Nombre = "Menu Administrador"};
            menuprincial.agregarMenu(menupelicula);
            menuprincial.agregarMenu(menuGenero);
            menuprincial.agregarMenu(menuCajero);
            menuprincial.agregarMenu(menuSala);

            menuprincial.mostrar();
        }
    }
}
