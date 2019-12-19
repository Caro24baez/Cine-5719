using Cine;
using MenuesConsola;
using System;
using System.Collections.Generic;

namespace ConsolaCajero.Menu
{
    public class MenuListaProyeccion : MenuListador<Proyeccion>
    {
        public Pelicula Pelicula { get; set; }

        public override void imprimirElemento(Proyeccion elemento)
           => Console.WriteLine($"{elemento.FechaHora} - Precio: {elemento.Valor} - Entradas Disponiles {elemento.EntradasDisponibles()}");

        public override List<Proyeccion> obtenerLista() => AdoCajero.ADO.ProyeccionDe(Pelicula);
    }
}