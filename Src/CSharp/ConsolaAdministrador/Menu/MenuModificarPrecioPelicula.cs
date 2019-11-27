using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Cine;

namespace ConsolaAdministrador.Menu
{
    public class MenuModificarPrecioPelicula : MenuListaPelicula
    {
        private object valor;

        public Proyeccion Proyeccion { get; set; }

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine();

            Proyeccion = seleccionarElemento();
            Console.WriteLine();
            menuModificarBoleto();
        }

        private void menuModificarBoleto()
        {
            bool cambio = true;
            if (preguntaCerrada("¿Cambiar el precio?"))
            {
                var precio = float.Parse(prompt("Precio Unitario"));
                Proyeccion.cambiarPrecioEntrada(valor);
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
