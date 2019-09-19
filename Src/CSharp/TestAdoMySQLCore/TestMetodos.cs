using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Cine;
using Cine.Ado;
using System.Linq;

namespace TestAdoMySQLCore
{
    [TestClass]
    public class TestMetodos
    {
        [TestMethod]
        public void entradasVendidasEntre()
        {
            var ado = new MySQLADo();
            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();
            Sala sala = new Sala(2, 100);
            Pelicula pelicula = new Pelicula("IT 2");
            Proyeccion proyeccion = new Proyeccion(pelicula, sala);
            ado.agregarPelicula(pelicula);
            Entrada entrada1 = new Entrada(350, proyeccion);
            ado.agregarEntrada(entrada1);
            Entrada entrada2 = new Entrada(150, proyeccion);
            ado.agregarEntrada(entrada2);
            Entrada entrada3 = new Entrada(350, proyeccion);
            ado.agregarEntrada(entrada3);
            Entrada entrada4 = new Entrada(150, proyeccion);
            ado.agregarEntrada(entrada4);

            var inicio = new DateTime(2009, 08, 02);
            var fin = new DateTime(2009, 08, 03);
            var resultado = proyeccion.EntradasVendidasEntre(inicio, fin);

            Assert.AreEqual(resultado.Count, 0);

        }
        
        
    }
}
