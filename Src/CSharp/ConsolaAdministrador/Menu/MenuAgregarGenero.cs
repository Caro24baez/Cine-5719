using System;
using System.Collections.Generic;
using System.Text;
using Cine;
using MenuesConsola;

namespace ConsolaAdministrador.Menu
{
    public class MenuAgregarGenero : MenuComponente
    {
        public Genero genero { get; set; }

        public MenuListaGeneros  menuListaGeneros { get; set; }
        public MenuAgregarGenero(MenuListaGeneros menuListaGeneros)
        {
            MenuListaGeneros = menuListaGeneros;
            Nombre = "Agreagar Generos";
        }
        public override void mostrar()
        {
            base.mostrar();
            var nombre = prompt("Ingrese el nombre del Genero");
        }

    }
}
