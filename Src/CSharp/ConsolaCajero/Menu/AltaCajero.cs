using MenuesConsola;
using System.Collections.Generic;
using System.Text;
using System;
using Cine;
using static System.ReadLine;

namespace ConsolaCajero.Cajero
{
    public class AltaCajero : MenuComponente
    {
        public Cajero Cajero { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            var dni = Convert.ToInt32("Ingrese DNI");
            var nombre = ("Ingrese nombre cajero");
            var apellido = ("Ingrese apellido");
            //Uso la libreria System.ReadLine para leer una contraseña
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            Cajero = new Cajero()
            {
                Apellido = apellido,
                Nombre = nombre,
                Dni = dni,
                Password = pass
            };
            try
            {
                AdoCajero.ADO.altaCajero(Cajero);
                Console.WriteLine("Cajero dada de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta: {e.Message}");
            }
            Console.ReadKey();
        }
    }


 }
