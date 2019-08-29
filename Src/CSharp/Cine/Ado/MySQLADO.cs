using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;


namespace Cine.Ado
{
    public class MySQLADo :DbContext, IADO
    {
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Pelicula> Pelicula { get; set; }
        public DbSet<PeliculaGenero> PeliculaGenero { get; set; }
        public DbSet<Proyeccion> Proyeccion { get; set; }
        public DbSet<Sala> Sala { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=cine;user=Cine;password=cine");
        }

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

        public void agregarProyeccion(Proyeccion proyeccion)
        {
            Proyeccion.Add(proyeccion);
            SaveChanges();
        }

        public void agregarSala(Sala sala)
        {
            Sala.Add(sala);
            SaveChanges();
        }

        

        public List<Proyeccion> obtenerProyecciones() => Proyeccion.ToList();

        public List<Entrada> obtenerEntradas() => Entradas.ToList();
        public List<Entrada> proyeccionDe(Proyeccion proyeccion)
        {
            return Entradas
                .Where(entrada => entrada.Proyeccion == proyeccion)
                .Include(entrada => entrada.Proyeccion)
                .ToList();
        }

        public List<Pelicula> obtenerPeliculas() => Pelicula.ToList();

    }
}
