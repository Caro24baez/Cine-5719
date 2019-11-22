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
        public MenuListaProyeccion menuListaProyeccion { get; set; }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("Seleccione una Proyeccion x)");
            var categoria = menuListaProyeccion.seleccionarElemento();

            entrada = new Entrada()
            {
               

                Cantidad = cantidad
            };
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
  

