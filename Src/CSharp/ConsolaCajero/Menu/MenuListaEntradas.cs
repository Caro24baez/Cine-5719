using System;
using System.Collections.Generic;
using System.Text;
using Cine;
using MenuesConsola;

namespace ConsolaCajero.Menu
{
    public class MenuListaEntradas : MenuListador<Entrada>
    {
        public Cajero cajero { get; set; }
        public override void imprimirElemento(Entrada elemento)
            => Console.WriteLine($"{elemento.FechaHora} - {elemento.cajero.Nombre}");

        public override List<Entrada> obtenerLista()
            => AdoCajero.ADO.obtenerEntradasParaCajero(cajero);

    }
}
