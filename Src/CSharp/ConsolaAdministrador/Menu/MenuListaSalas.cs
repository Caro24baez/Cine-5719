using MenuesConsola;
using Cine;
using System;
using System.Collections.Generic;
using System.Text;
using ConsolaAdministrador;

namespace ConsolaAdministrador.Menu
{
    public class MenuListaSala : MenuListador<Sala>
    {
        public override void imprimirElemento(Sala elemento)
        {
            Console.WriteLine($"{elemento.Id}{elemento.Capacidad} {elemento.Piso}");
        }
        public override List<Sala> obtenerLista() => AdoAdministrador.ADO.obtenerSalas();
    }    
}