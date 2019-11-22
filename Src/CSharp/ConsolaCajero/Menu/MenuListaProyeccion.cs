using System;
using System.Collections.Generic;
using System.Text;
using MenuesConsola;
using Cine;
namespace ConsolaCajero.Menu
{
    public class MenuListaProyeccion : MenuListador<Proyeccion>
    {
        public override void imprimirElemento(Proyeccion elemento)
           => Console.WriteLine($"{elemento.Id} - Pelicula: {elemento.Pelicula.Nombre} - Precio: {elemento.Valor}");

        public override List<Proyeccion> obtenerLista() => AdoCajero.ADO.obtenerProyecciones();
    }
}
