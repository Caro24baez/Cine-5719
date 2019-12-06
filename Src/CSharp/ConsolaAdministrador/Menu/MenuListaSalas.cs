using Cine;
using MenuesConsola;
using System;
using System.Collections.Generic;

namespace ConsolaAdministrador.Menu
{
    public class MenuListaSala : MenuListador<Sala>
    {
        public override void imprimirElemento(Sala elemento)
        {
            Console.WriteLine($"{elemento.Id} Capacidad: {elemento.Capacidad} Piso {elemento.Piso}°");
        }
        public override List<Sala> obtenerLista() => AdoAdministrador.ADO.obtenerSalas();
    }    
}