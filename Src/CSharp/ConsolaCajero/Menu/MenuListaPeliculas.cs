using MenuesConsola;
using Cine;
using System;
using System.Collections.Generic;
using System.Text;
using ConsolaCajero;
namespace ConsolaCajero.Menu
{
    public class MenuListaPelicula : MenuListador<Pelicula>
    {
        public override void imprimirElemento(Pelicula elemento)
        {
            Console.WriteLine($"{elemento.Nombre}");
        }
        public override List<Pelicula> obtenerLista() => AdoCajero.ADO.obtenerPeliculas();
    }
}
