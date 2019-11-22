using System;
using MenuesConsola;
using NETCore.Encrypt;
using Cine;
using static System.ReadLine;
using ConsolaCajero.Menu;

namespace consolaCajero.Menu
{
    public class Login : MenuCompuesto
    {
        public Cajero Cajero { get; set; }
        public MenuCompuesto PrincipalUsuario { get; set; }


        public override void mostrar()
        {
            base.mostrar();

            var mail = prompt("Ingrese mail: ");
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);
            Cajero = ConsolaCajero.AdoCajero.ADO.cajeroPorMailyPass(mail, pass);
            try
            {
                if (Cajero is null)
                {
                    Console.WriteLine("Email es incorrecta");
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
            var menuListaProyeccion = new MenuListaProyeccion();
            var menuAltaEntrada = new MenuAltaEntrada() { Nombre = "Alta Entrada" };

            var menuListaEntradas = new MenuListaEntradas() { Nombre = "Lista Entradas" , cajero = cajero};

            PrincipalUsuario = new MenuCompuesto() { Nombre = "Login" };
            PrincipalUsuario.agregarMenu(menuAltaEntrada);
            PrincipalUsuario.agregarMenu(menuListaEntradas);

        }
    }
}
