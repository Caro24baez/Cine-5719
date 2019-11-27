using Cine;
using Cine.Ado;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAdoMySQLCore
{
    [TestClass]
    public class TestMetodos
    {
        [ClassInitialize]
        public static void iniciarClase(TestContext testContext)
        {
            var ado = new MySQLADO();
            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();
        }

        //[TestMethod]
        //public void entradasVendidasEntre()
        //{

        //    var ado = new MySQLADO();
        //    Sala sala = new Sala(2, 100);
        //    Pelicula pelicula = new Pelicula("IT 2");
        //    Proyeccion proyeccion = new Proyeccion(pelicula, sala, 90);
        //    ado.agregarPelicula(pelicula);
        //    proyeccion.venderEntrada();
        //    proyeccion.venderEntrada();
        //    proyeccion.venderEntrada();
        //    proyeccion.venderEntrada();
        //    ado.actualizar(proyeccion);
        //    var inicio = new DateTime(2009, 08, 02);
        //    var fin = new DateTime(2009, 08, 03);
        //    var resultado = proyeccion.EntradasVendidasEntre(inicio, fin);

        //    Assert.AreEqual(resultado.Count, 0);
        //}

        //[TestMethod]
        //public void entradasDisponibles()
        //{
        //    var ado = new MySQLADO();
        //    Sala sala = new Sala(3, 500);
        //    Pelicula pelicula = new Pelicula("Odisea de los Giles");
        //    Proyeccion proyeccion = new Proyeccion(pelicula, sala, 80);
        //    ado.agregarPelicula(pelicula);


        //    int resulta2 = proyeccion.EntradasDisponibles();

        //    Assert.AreEqual(resulta2, -500);
        //}

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

            Entrada unaEntrada = new Entrada(unaProyeccion);
            ado.agregarEntrada(unaEntrada);

            Cajero unCajero = new Cajero(94065533, "juan","Paloma", "juanp@gmail.com", "1234");
            ado.agregarCajero(unCajero);
        }
    }
}
