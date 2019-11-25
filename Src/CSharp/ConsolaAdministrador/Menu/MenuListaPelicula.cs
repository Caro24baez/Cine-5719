using MenuesConsola;
using Cine;
using System;
using System.Collections.Generic;
using System.Text;
using ConsolaAdministrador;
namespace ConsolaAdministrador.Menu
{
    public class MenuListaPelicula : MenuListador<Pelicula>
    {
        public override void imprimirElemento(Pelicula elemento)
        {
            Console.WriteLine($"{elemento.Nombre}\t\t{elemento.id}");
        }

        public override List<Pelicula> obtenerLista() => AdoAdministrador.ADO.obtenerPeliculas();


    }
}
