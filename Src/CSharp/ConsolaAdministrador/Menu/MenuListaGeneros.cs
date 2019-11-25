using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Cine;

namespace ConsolaAdministrador.Menu
{
    public class MenuListaGeneros : MenuListador<Genero>
    {
        public override void imprimirElemento(Genero elemento)
        {
            Console.WriteLine($"{elemento.Id} - {elemento.genero}");
        }

        public override List<Genero> obtenerLista() => AdoAdministrador.ADO.obtenerGeneros();
    }
}
