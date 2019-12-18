using System;
using System.Collections.Generic;
using System.Text;
using Cine;
using MenuesConsola;

namespace ConsolaAdministrador.Menu
{
    public class MenuAgregarGenero : MenuComponente
    {
        public Genero Genero { get; set; }
        public MenuListaGeneros  MenuListaGeneros { get; set; }
        public MenuAgregarGenero(MenuListaGeneros menuListaGeneros)
        {
            MenuListaGeneros = menuListaGeneros;
            Nombre = "Agregar Generos";
        }
        public override void mostrar()
        {
            base.mostrar();
            
            var genero = prompt("Ingrese el nombre del Genero");
            Console.WriteLine("Seleccione una categoria x)");
            var Genero = MenuListaGeneros.seleccionarElemento();
          
            Genero = new Genero()
            {
                genero = genero
            };

            try
            {
                AdoAdministrador.ADO.agregarGenero(Genero);
                Console.WriteLine("Genero agregado con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo agregar el genero :{e.Message}");
            }

            Console.ReadKey();
        }   
    }
}
