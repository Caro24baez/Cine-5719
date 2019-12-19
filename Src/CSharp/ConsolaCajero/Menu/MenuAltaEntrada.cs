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

        public MenuAltaEntrada(MenuListaProyeccion menuListaProyeccion, Cajero cajero)
        {
            this.menuListaProyeccion = menuListaProyeccion;
            this.Cajero = cajero;
            Nombre = "Lista Proyeccion";
        }

        public override void mostrar()
        {
            base.mostrar();

            var dni = Convert.ToInt32("Ingrese DNI");
            var proyeccion = menuListaProyeccion.seleccionarElemento();
            var valor = double.Parse(prompt("Ingrese precio unitario"));

            proyeccion.venderEntrada(Cajero);
            try
            {
                
                Console.WriteLine("Producto dado de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta el producto: {e.Message}");
            }
        }


    }  
     
}
 