using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaNegocio;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new NVentanilla();
            string ubicacion = "A17";
            string tipo = "VIP";
            var exp = c.insertarVentanilla(ubicacion, tipo);
            Assert.AreEqual(exp, c.insertarVentanilla("A17", "VIP"));
        }
    }
}
