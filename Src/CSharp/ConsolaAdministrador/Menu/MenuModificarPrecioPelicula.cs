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

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine();

            Pelicula = seleccionarElemento();
            Console.WriteLine();
            menuModificarPrecioPelicula();
        }

        private void menuModificarPrecioPelicula()
        {
            bool cambio = false;
            if (preguntaCerrada("¿Cambiar el precio?"))
            {
                var precio = int.Parse(prompt("Precio Unitario"));
                cambio = true;
            }
            if (cambio)
            {
                try
                {
                    AdoAdministrador.ADO.actualizarEntrada(Proyeccion);
                    Console.WriteLine("Entrada actualizado con exito");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"No se pudo modificar por: {e.InnerException.Message}");
                }
                Console.ReadKey();
            }
        }
    }
}