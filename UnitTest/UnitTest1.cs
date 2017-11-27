using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaNegocio;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase]
        public void TestMethod1()
        {
            var c = new NVentanilla();
            string ubicacion = "A17";
            string tipo = "VIP";
            var exp = c.insertarVentanilla(ubicacion, tipo); 
            NUnit.Framework.Assert.AreEqual(exp, c.insertarVentanilla("A17", "VIP"));
        }
    }
}
