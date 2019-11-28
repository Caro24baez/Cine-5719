﻿using System;
using MenuesConsola;
using NETCore.Encrypt;
using Cine;
using static System.ReadLine;
using ConsolaCajero.Menu;

namespace consolaCajero.Menu
{
    public class Login : MenuComponente
    {
        public Cajero Cajero { get; set; }
        public MenuCompuesto PrincipalUsuario { get; set; }


        public override void mostrar()
        {
            base.mostrar();

            var mail = prompt("Ingrese Email: ");
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);
            try
            {
                Cajero = ConsolaCajero.AdoCajero.ADO.cajeroPorMailyPass(mail, pass);
                if (Cajero is null)
                {
                    Console.WriteLine("El mail o la contraseña es incorrecta");
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
            var menuListaProyeccion = new MenuListaProyeccion() { Nombre = "Alta Lista Proyyecciones"};
            var menuAltaEntrada = new MenuAltaEntrada(menuListaProyeccion, Cajero) { Nombre = "Alta Entrada" };

            var menuListaEntradas = new MenuListaEntradas() { Nombre = "Lista Entradas"};

            PrincipalUsuario = new MenuCompuesto() { Nombre = "Usuario" };
            PrincipalUsuario.agregarMenu(menuAltaEntrada);
            PrincipalUsuario.agregarMenu(menuListaEntradas);

        }
    }
}
