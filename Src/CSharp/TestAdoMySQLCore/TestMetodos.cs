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
        [TestMethod]
        public void entradasVendidasEntre()
        {
            
            var ado = new MySQLADO();
            Sala sala = new Sala(2, 100);
            Pelicula pelicula = new Pelicula("IT 2");
            Proyeccion proyeccion = new Proyeccion(pelicula, sala, 90);
            ado.agregarPelicula(pelicula);
            proyeccion.venderEntrada();
            proyeccion.venderEntrada();
            proyeccion.venderEntrada();
            proyeccion.venderEntrada();
            ado.actualizar(proyeccion);
            var inicio = new DateTime(2009, 08, 02);
            var fin = new DateTime(2009, 08, 03);
            var resultado = proyeccion.EntradasVendidasEntre(inicio, fin);

            Assert.AreEqual(resultado.Count, 0);

        }
        [TestMethod]
        public void entradasDisponibles()
        {
            var ado = new MySQLADO();
            Sala sala = new Sala(3, 500);
            Pelicula pelicula = new Pelicula("Odisea de los Giles");
            Proyeccion proyeccion = new Proyeccion(pelicula, sala, 80);
            ado.agregarPelicula(pelicula);

            
            int resulta2 = proyeccion.EntradasDisponibles();

            Assert.AreEqual(resulta2, -500);


        }

    }
}
