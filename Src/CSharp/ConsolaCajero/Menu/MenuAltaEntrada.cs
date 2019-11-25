﻿using System;
using Cine;
using ConsolaCajero;
using static System.ReadLine;
using MenuesConsola;


namespace ConsolaCajero.Menu
{
    public class MenuAltaEntrada : MenuComponente
    {

        public Entrada entrada { get; set; }
        public MenuListaProyeccion menuListaProyeccion { get; set; }

        public MenuAltaEntrada(MenuListaProyeccion menuListaProyeccion)
        {
            this.menuListaProyeccion = menuListaProyeccion;
            Nombre = "Lista Proyeccion";
        }

        public MenuAltaEntrada()
        {
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("Seleccione una Proyeccion x)");
            var proyeccion = menuListaProyeccion.seleccionarElemento();

            entrada = new Entrada(proyeccion);
            try
            {
                AdoCajero.ADO.agregarEntrada(entrada);
                Console.WriteLine("Producto dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta el producto: {e.Message}");
            }
        }


    }  
     
}
  
