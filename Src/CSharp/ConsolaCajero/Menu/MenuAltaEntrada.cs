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

            var dni = Convert.ToInt32("Ingrese DNI");
            var proyeccion = prompt("Ingrese una Proyeccion: ");
            var cajero = prompt("Ingrese un Cajero: ");
            var valor = prompt("Ingrese el Valor de La entrada: ");
            var fechaHora = Convert.ToDateTime(prompt("Ingrese Fecha AAAA/MM/DD y hora HH:HH"));

            entrada = new Entrada()
            {
                Proyeccion = proyeccion,
                Cajero = cajero,
                Valor = valor,
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
 