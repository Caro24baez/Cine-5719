using System;
using System.Collections.Generic;
using MenuesConsola;
using System.Text;
using ConsolaAdministrador;
using Cine;
using Cine.Ado;

namespace ConsolaAdministrador.Menu
{
    public class MenuListaProyeccion : MenuListador<Proyeccion>
    {
        public IADO ADO { get; set; }
        public override void imprimirElemento(Proyeccion p)
        {
            Console.WriteLine($"{p.Id} Pelicula:{p.Pelicula} FechaHora:{p.FechaHora} Sala:{p.Sala} Precio:{p.Valor}");
        }
        public override List<Proyeccion> obtenerLista() => AdoAdministrador.ADO.obtenerProyecciones();

    }
}
