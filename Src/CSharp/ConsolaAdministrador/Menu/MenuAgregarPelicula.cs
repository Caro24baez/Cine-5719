﻿using System;
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
            Nombre = "Agregar pelicula: ";

        }

        public override void mostrar()
        {
            base.mostrar();

            var pelicula = prompt("Ingrese el nombre de la pelicula: ");

            Pelicula = new Pelicula()
            {
                Nombre = pelicula
            };
             try
            {
                AdoAdministrador.ADO.agregarPelicula(Pelicula);
                Console.WriteLine("Pelicula agregado con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo agregar la pelicula :{e.Message}");
            }

            Console.ReadKey();


        }
    }
}
