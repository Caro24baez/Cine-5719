using System;
using System.Collections.Generic;
using System.Text;


namespace Cine.Ado
{
    public class MySQLADo : IADO
    {
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Pelicula> Pelicula { get; set; }
        public DbSet<PeliculaGenero> PeliculaGenero { get; set; }
        public DbSet<Proyeccion> Proyeccion { get; set; }
        public DbSet<Sala> Sala { get; set; }

       
    }
}
