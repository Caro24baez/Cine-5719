using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Cine;

namespace ConsolaAdministrador.Menu
{
    public class MenuModificarPrecioPelicula : MenuListaPelicula
    {
        public float valor;
<<<<<<< HEAD
        public Pelicula Pelicula { get; set; }
=======

        public Pelicula Pelicula { get; set; }
        public Proyeccion Proyeccion { get; set; }
>>>>>>> b6bc46fa588c1652c59ed8dbfacb271cd99038fd

        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine();

<<<<<<< HEAD
            Pelicula = seleccionarElemento();
=======
            Proyeccion = seleccionarElemento();
>>>>>>> b6bc46fa588c1652c59ed8dbfacb271cd99038fd
            Console.WriteLine();
            menuModificarPrecioPelicula();
        }

        private void menuModificarPrecioPelicula()
        {
            bool cambio = true;
            if (preguntaCerrada("¿Cambiar el precio?"))
            {
                var precio = float.Parse(prompt("Precio Unitario"));
                Pelicula.cambiarPrecioEntrada(valor);
                cambio = true;
            }
            if (cambio)
            {
                try
                {
                    AdoAdministrador.ADO.actualizarEntrada(Pelicula);
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