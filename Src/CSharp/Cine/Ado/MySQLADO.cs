using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;


namespace Cine.Ado
{
    public class MySQLADo :DbContext, IADO
    {
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Pelicula> Pelicula { get; set; }
        public DbSet<PeliculaGenero> PeliculaGenero { get; set; }
        public DbSet<Proyeccion> Proyeccion { get; set; }
        public DbSet<Sala> Sala { get; set; }

         
        public virtual void agregarPelicula(Pelicula pelicula)
        {
            Pelicula.Add(pelicula);
            SaveChanges();
        }

        public void agregarEntrada(Entrada entrada)
        {
            Entrada.Add(entrada);
            SaveChanges();
        }
        public void agregarGenero(Genero genero)
        {
            Genero.Add(genero);
            SaveChanges();
        }

        public void actualizarEntrada(Entrada entrada)
        {
            this.Update<Entrada>(entrada);
            SaveChanges();
        }
        public List<Proyeccion> obtenerProyecciones() => Proyeccion.ToList();
        public List<Entrada> obtenerEntradas(Proyeccion proyeccion)
        {
            return Entrada
                .Where
                .Include(entrada => entrada.Proyeccion)
                .ToList();
        }


    }
}
