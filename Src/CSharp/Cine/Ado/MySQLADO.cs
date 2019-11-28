using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace Cine.Ado
{
    public class MySQLADO : DbContext, IADO
    {
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<PeliculaGenero> PeliculasGeneros { get; set; }
        public DbSet<Proyeccion> Proyecciones { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Cajero>Cajeros { get; set;}

        public MySQLADO() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=cine;user=root;password=root");
        }

        internal MySQLADO(DbContextOptions dbo) : base(dbo) { }

        public void agregarPelicula(Pelicula pelicula)
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

        public void agregarPeliculaGenero(PeliculaGenero peliculaGenero)
        {
            PeliculasGeneros.Add(peliculaGenero);
            SaveChanges();
        }

        public void agregarCajero(Cajero cajero)
        {
            Cajeros.Add(cajero);
            SaveChanges();
        }

        public void actualizarEntrada(Entrada entrada)
        {
            this.Update<Entrada>(entrada);
            SaveChanges();
        }


        public List<Proyeccion> obtenerProyecciones() => Proyecciones.ToList();

        public List<Proyeccion> obtenerProyeccionDe(Pelicula pelicula)
        {
            return Proyecciones
                .Where(proyeccion => proyeccion.Pelicula == pelicula)
                .ToList();
        }

        public List<Entrada> obtenerEntradasParaCajero() => Entradas.ToList();
        public List<Entrada> proyeccionDe(Proyeccion proyeccion)
        {
            return Entradas
                .Where(entrada => entrada.Proyeccion == proyeccion)
                .Include(entrada => entrada.Proyeccion)
                .ToList();
        }

        public List<Pelicula> obtenerPeliculas() => Peliculas.ToList();

        public void actualizar(Proyeccion proyeccion)
        {
            Proyecciones.Update(proyeccion);
            SaveChanges();
        }             
        public List<Cajero> obtenerCajeros()
        {
            throw new NotImplementedException();
        }

        public List<Entrada> obtenerEntradasParaCajero(Cajero cajero)
        {
            return Entradas.Where(x => x.Cajero.Dni == cajero.Dni).Include(p => p.Proyeccion).ToList();
        }

        public Cajero cajeroPorMailyPass(string mail, string pass) =>
        Cajeros.FirstOrDefault(c => c.Email == mail && c.Contrasenia == pass);       

        public List<Sala> obtenerSalas()
        {
            throw new NotImplementedException();
        }

        public void actualizarEntrada(Proyeccion proyeccion)
        {
            throw new NotImplementedException();
        }

        public List<Genero> obtenerGeneros() => Generos.ToList();

        public void actualizarEntrada(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }
    }
}