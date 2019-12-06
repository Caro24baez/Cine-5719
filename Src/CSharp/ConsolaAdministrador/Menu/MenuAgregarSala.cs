using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Cine;
namespace ConsolaAdministrador.Menu
{
    public class MenuAgregarSala : MenuComponente
    {
        public Sala Sala { get; set; }

        public MenuAgregarSala()
        {
            Nombre = "Agregar Sala";
        }

        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();

            var capacidad = Convert.ToInt16(prompt("Ingrese la capacidad de la sala"));
            var piso = Convert.ToByte(prompt("Ingrese el numero piso de la sala"));

            Sala = new Sala()
            {
                Capacidad = capacidad,
                Piso = piso
            };

            try
            {
                AdoAdministrador.ADO.agregarSala(Sala);
                Console.WriteLine("Sala agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo agregar la sala {e.Message}");
            }

            Console.ReadKey();
        }
    }
}
