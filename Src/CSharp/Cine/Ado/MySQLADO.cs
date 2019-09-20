using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;


namespace Cine.Ado
{
    public class MySQLADo : DbContext, IADO
    {
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<PeliculaGenero> PeliculaGeneros { get; set; }
        public DbSet<Proyeccion> Proyecciones { get; set; }
        public DbSet<Sala> Salas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=cine;user=root;password=admin");
        }

        public virtual void agregarPelicula(Pelicula pelicula)
        {
            Peliculas.Add(pelicula);
            SaveChanges();
        }

        public void agregarEntrada(Entrada entrada)
        {
            Entradas.Add(entrada);
            SaveChanges();
        }
        public void agregarGenero(Genero genero)
        {
            Generos.Add(genero);
            SaveChanges();
        }


        public void actualizarEntrada(Entrada entrada)
        {
            this.Update<Entrada>(entrada);
            SaveChanges();
        }

        public void agregarProyeccion(Proyeccion proyeccion)
        {
            Proyecciones.Add(proyeccion);
            SaveChanges();
        }

        public void agregarSala(Sala sala)
        {
            Salas.Add(sala);
            SaveChanges();
        }



        public List<Proyeccion> obtenerProyecciones() => Proyecciones.ToList();

        public List<Entrada> obtenerEntradas() => Entradas.ToList();
        public List<Entrada> proyeccionDe(Proyeccion proyeccion)
        {
            return Entradas
                .Where(entrada => entrada.Proyeccion == proyeccion)
                .Include(entrada => entrada.Proyeccion)
                .ToList();
        }

        public List<Pelicula> obtenerPeliculas() => Peliculas.ToList();

        public List<Genero> obtenerGenero() => Generos.ToList();

        public void actualizar(Proyeccion proyeccion)
        {
            Proyecciones.Update(proyeccion);
            SaveChanges();
        }

        //public List<Genero> obtenerGeneros()
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Proyeccion> proyeccionDe(Entrada entrada)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Sala> obtenerSalas()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
