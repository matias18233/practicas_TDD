using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PricingService;

namespace PricingServiceTest {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void precioConDescuento() {
            float[] valores = new float[2];
            valores[0] = 100;
            valores[1] = 10;
            
            valoresExtra valoresExtra = new valoresExtra(15, 50);

            Program servicioPrecio = new Program(valores, valoresExtra);

            float precioTotal = servicioPrecio.CalcularPrecioTotal();
            
            Assert.AreEqual(precioTotal, 161.00);
        }
        [TestMethod]
        public void precioSinDescuento() {
            float[] valores = new float[2];
            valores[0] = 100;
            valores[1] = 0;

            valoresExtra valoresExtra = new valoresExtra(15, 50);

            Program servicioPrecio = new Program(valores, valoresExtra);

            float precioTotal = servicioPrecio.CalcularPrecioTotal();

            Assert.AreEqual(precioTotal, 172.50);
        }
    }
}
