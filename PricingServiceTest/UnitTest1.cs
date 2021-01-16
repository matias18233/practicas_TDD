using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PricingService;

namespace PricingServiceTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            float[] valores = new float[2];
            valores[0] = 100;
            valores[1] = 10;
            
            valoresExtra valoresExtra = new valoresExtra(15, 50);

            Program servicioPrecio = new Program(valores, valoresExtra);

            float precioTotal = servicioPrecio.CalcularPrecioTotal();
            
            Assert.AreEqual(precioTotal, 161.00);
        }
    }
}
