using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingService {
    public class Program {
        float[] _orden;
        public float[] Orden {
            get => _orden;
            set => _orden = value;
        }
        valoresExtra valoresExtra;
        public valoresExtra ValoresExtra {
            get => valoresExtra;
            set => valoresExtra = value;
        }
        static void Main(string[] args) {

        }
        public Program(float[] Porden, valoresExtra PvaloresExtra) {
            Orden = Porden;
            ValoresExtra = PvaloresExtra;
        }
        public float CalcularPrecioTotal() {
            float precioOrden = aplicarDescuento() + aplicarCargosEnvio();
            float total = aplicarImpuestos(precioOrden);
            return total;
        }
        private float aplicarDescuento() {
            return Orden[0] - Orden[1];
        }
        private float aplicarCargosEnvio() {
            return ValoresExtra.GastoEnvio;
        }
        private float aplicarImpuestos(float PprecioOrden) {
            return PprecioOrden * ValoresExtra.Impuesto;
        }
    }
}
