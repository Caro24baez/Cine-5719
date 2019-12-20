using Cine;
using Cine.Ado;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace TestAdoMySQLCore
{
    [TestClass]
    public class TestMetodos
    {
        [TestMethod]
        public void RealizarVentaEntrada()
        {
            var ado = new MySQLADO();
            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();

            Sala unaSala = new Sala(1, 500);
            ado.agregarSala(unaSala);

            Pelicula unaPelicula = new Pelicula("Garfield 2");
            ado.agregarPelicula(unaPelicula);

            Genero unGenero = new Genero("Fantasia");
            ado.agregarGenero(unGenero);

            PeliculaGenero unaPeliculaGenero = new PeliculaGenero(unGenero.Id, unaPelicula.id);
            ado.agregarPeliculaGenero(unaPeliculaGenero);

            Proyeccion unaProyeccion = new Proyeccion(unaPelicula, unaSala, 180);
            ado.agregarProyeccion(unaProyeccion);

            Cajero unCajero = new Cajero(94065533, "juan", "Paloma", "juanp@gmail.com", "12345678");
            ado.agregarCajero(unCajero);

            Entrada unaEntrada = new Entrada(unaProyeccion, unCajero);
            ado.agregarEntrada(unaEntrada);

            int num = unaSala.Piso;
            Assert.AreEqual(num, 1);
        }
    }
}