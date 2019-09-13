using Cine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Cine.test
{
    [TestClass]
    public class EntradaTests
    {
        [TestMethod]
        public void cambiarValorEntrada_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var entrada = new Entrada();
            int valor = 0;

            // Act
            entrada.cambiarValorEntrada(valor);

            // Assert
            Assert.Fail();
        }
    }
}
