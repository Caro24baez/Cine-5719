using MenuesConsola;
using Cine;
using System;
using System.Collections.Generic;
using ConsolaCajero;

namespace ProgramaGerente.Menu
{
    public class MenuListaCajeros : MenuListador<Cajero>
    {
        public override void imprimirElemento(Cajero elemento)
        {
            Console.WriteLine($"{elemento.NombreCompleto}\t\t{elemento.Dni}");
        }

        public override List<Cajero> obtenerLista() => AdoCajero.ADO.obtenerCajeros();
    }
}

