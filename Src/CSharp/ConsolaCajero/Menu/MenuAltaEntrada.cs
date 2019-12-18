using System;
using Cine;
using ConsolaCajero;
using static System.ReadLine;
using MenuesConsola;


namespace ConsolaCajero.Menu
{
    public class MenuAltaEntrada : MenuComponente
    {

        public Entrada entrada { get; set; }
        public Cajero cajero { get; set; }
        public MenuListaProyeccion menuListaProyeccion { get; set; }

        public MenuAltaEntrada(MenuListaProyeccion menuListaProyeccion, Cajero cajero)
        {
            this.menuListaProyeccion = menuListaProyeccion;
            this.cajero = cajero;
            Nombre = "Lista Proyeccion";
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("Seleccione una Proyeccion");
            var proyeccion = menuListaProyeccion.seleccionarElemento();

            proyeccion.venderEntrada(cajero);
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
 