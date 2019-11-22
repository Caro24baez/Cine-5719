using System;
using NETCore.Encrypt;
using Cine;
using MenuesConsola;
using static System.ReadLine;
using ConsolaCajero;

namespace consolaCajero
{
    public class MenuAltaCajero : MenuComponente

    {
       public Cajero Cajero { get; set; }
        public override void mostrar()
        {
            base.mostrar();

            var dni = Convert.ToInt32(prompt("Ingrese su DNI: "));
            var nombre = prompt("Ingrese nombre cajero: ");
            var apellido = prompt("Ingrese apellido: ");
            var email = prompt("Ingrese su Email: ");
            var pass = ReadPassword("Ingrese su contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            Cajero = new Cajero()
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Contrasenia = pass,
                Email = email,
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
}
