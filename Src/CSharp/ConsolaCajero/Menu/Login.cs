using System;
using MenuesConsola;
using NETCore.Encrypt;
using Cine;
using static System.ReadLine;
using ConsolaCajero;

namespace consolaCajero
{
    public class Login : MenuComponente
    {
        public Cajero Cajero { get; set; }
        public MenuComponente PrincipalUsuario { get; set; }


        public override void mostrar()
        {
            base.mostrar();

            var dni = Convert.ToInt32(prompt("Ingrese dni"));
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            try
            {
                Cajero = AdoCajero.ADO.cajeroPorDni(dni, pass);
                if (Cajero is null)
                {
                    Console.WriteLine("DNI o contraseña incorrecta");
                    Console.ReadKey();
                }
                else
                {
                    instanciarMenuesPara(Cajero);
                    PrincipalUsuario.mostrar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo iniciar sesion debido a un error: {e.Message}");
                Console.ReadKey();
            }
        }

        public void instanciarMenuesPara(Cajero cajero)
        {
        }
    }
}
