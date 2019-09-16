using Cine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cine.test
{
    [TestClass]
    public class ProyeccionTests
    {
        Proyeccion proyeccion { get; set; }

        [TestMethod]
        public void horaFuncion_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var proyeccion = new Proyeccion();
            DateTime inicio = default(global::System.DateTime);
            DateTime fin = default(global::System.DateTime);

            // Act
            var result = proyeccion.horaFuncion(
                inicio,
                fin);

            // Assert
            Assert.AreEqual(2,3);

        }
    }
}
