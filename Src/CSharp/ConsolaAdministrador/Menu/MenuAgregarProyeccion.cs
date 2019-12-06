using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using ConsolaAdministrador;
using Cine;

namespace ConsolaAdministrador.Menu
{
    public class MenuAgregarProyeccion : MenuComponente
    {
        public Proyeccion Proyeccion { get; set; }
        public MenuListaProyeccion MenuListaProyeccion { get; set; }
        public MenuAgregarProyeccion (MenuListaProyeccion menuListaProyeccion)
        {
            MenuListaProyeccion = menuListaProyeccion;
            Nombre = "Agregar Proyeccion";
        }
    }
}
