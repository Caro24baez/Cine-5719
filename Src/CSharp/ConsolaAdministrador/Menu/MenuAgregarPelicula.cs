using System;
using System.Collections.Generic;
using System.Text;
using Cine;
using MenuesConsola;

namespace ConsolaAdministrador.Menu
{
    public class MenuAgregarPelicula : MenuComponente
    {
        public Pelicula Pelicula { get; set; }

        public MenuListaPelicula MenuListaPelicula { get; set; }

        public MenuAgregarPelicula(MenuListaPelicula menuListaPelicula)
        {
            MenuListaPelicula = menuListaPelicula;
            Nombre = "Agregar pelicula";

        }

        public override void mostrar()
        {
            base.mostrar();
            var nombre = prompt("Ingrese el nombre de la pelicula");
        }
    }
}
