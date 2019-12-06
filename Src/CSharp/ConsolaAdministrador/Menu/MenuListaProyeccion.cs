using System;
using System.Collections.Generic;
using MenuesConsola;
using System.Text;
using ConsolaAdministrador;
using Cine;

namespace ConsolaAdministrador.Menu
{
    public class MenuListaProyeccion : MenuListador<Proyeccion>
    {
        public override void imprimirElemento(Proyeccion elemento)
        {
            Console.WriteLine($"{elemento.Id}-{elemento.Pelicula}-{elemento.FechaHora}-{elemento.Sala}-{elemento.Valor}");
        }
        public override List<Proyeccion> obtenerLista() => AdoAdministrador.ADO.obtenerProyecciones();
    }
}
