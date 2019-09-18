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
    public class TestsPersistencia
    {
        static MySQLADo Ado { get; set; }
        [ClassInitialize]
        public static void iniciarClase(TestContext context)
        {
            instanciarPropiedades();
            Ado = new MySQLADo();
            Ado.Database.EnsureCreated();
            Ado.Database.EnsureCreated();
            agregarObjetosPersistir();
        }

        private static void instanciarPropiedades()
        {

        }

        private static void agregarObjetosPersistir()
        {

        }

        [TestMethod]
        public void cambiarValorEntrada()
        {
          

        }
    }
}
