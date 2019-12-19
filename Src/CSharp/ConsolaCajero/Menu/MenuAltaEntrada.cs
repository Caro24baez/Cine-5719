using System;
using NETCore.Encrypt;
using Cine;
using MenuesConsola;
using static System.ReadLine;
using ConsolaCajero;


namespace ConsolaCajero.Menu
{
    public class MenuAltaEntrada : MenuComponente
    {

        public Cajero Cajero { get; set; }

        public MenuListaProyeccion menuListaProyeccion { get; set; }
        public MenuListaPelicula menuListaPelicula { get; set; } = new MenuListaPelicula();

        public MenuAltaEntrada(Cajero cajero)
        {
            this.Cajero = cajero;
            Nombre = "Lista Proyeccion";
        }

        public override void mostrar()
        {
            base.mostrar();

            var pelicula = menuListaPelicula.seleccionarElemento();
            menuListaProyeccion = new MenuListaProyeccion() { Pelicula = pelicula };
            var proyeccion = menuListaProyeccion.seleccionarElemento();

            proyeccion.venderEntrada(Cajero);

            try
            {
                AdoCajero.ADO.actualizarProyeccion(proyeccion);
                Console.WriteLine("Entrada vendida con exito");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta la entrada: {e.Message}");
            }
        }
    }       
}
 