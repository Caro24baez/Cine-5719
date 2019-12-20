using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Cine;

namespace ConsolaAdministrador.Menu
{
    public class MenuModificarPrecioPelicula : MenuListaPelicula
    {
        public Pelicula Pelicula { get; set; }
        public Proyeccion Proyeccion { get; set; }
        public MenuListaProyeccion menuListaProyeccion { get; set; } = new MenuListaProyeccion();

        public MenuModificarPrecioPelicula (MenuListaProyeccion menuListaProyeccion, Pelicula pelicula)
        {
            this.menuListaProyeccion = menuListaProyeccion;
            Pelicula = pelicula;
        }

        public MenuModificarPrecioPelicula()
        {
        }

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine();

            Pelicula = seleccionarElemento();
            Proyeccion = menuListaProyeccion.seleccionarElemento();
        }

        public void menuModificarPrecioPelicula()
        {
            bool cambio = false;
            if (preguntaCerrada("¿Cambiar el precio?"))
            {
                var precio = double.Parse(prompt("Precio Unitario"));
                cambio = true;
            }

            if (cambio)
            {
                try
                {
                    AdoAdministrador.ADO.actualizarProyeccion(Proyeccion);
                    Console.WriteLine("Entrada actualizado con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.Message}");
                }
                Console.ReadKey();
            }
        }
    }
}