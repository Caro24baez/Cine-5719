using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Cine;

namespace ConsolaAdministrador.Menu
{
    public class MenuModificarPrecioPelicula : MenuListaPelicula
    {
        //public int valor;

        public Pelicula Pelicula { get; set; }
        public Proyeccion Proyeccion { get; set; }

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine();

            //Proyeccion = seleccionarElemento();
            Console.WriteLine();
            menuModificarPrecioPelicula();
        }

        private void menuModificarPrecioPelicula()
        {
            bool cambio = true;
            if (preguntaCerrada("¿Cambiar el precio?"))
            {
                var precio = int.Parse(prompt("Precio Unitario"));
                Pelicula.cambiarPrecioEntrada(precio);
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
            }
        }
    }
}