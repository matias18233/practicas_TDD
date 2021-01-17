using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingService {
    public class Program {
        private float[] _orden;
        public float[] Orden {
            get => _orden;
            set => _orden = value;
        }
        private valoresExtra valoresExtra;
        public valoresExtra ValoresExtra {
            get => valoresExtra;
            set => valoresExtra = value;
        }
        private float precioOrden;
        public float PrecioOrden {
            get => precioOrden;
            set => precioOrden = value;
        }
        static void Main(string[] args) {

        }
        public Program(float[] Porden, valoresExtra PvaloresExtra) {
            Orden = Porden;
            ValoresExtra = PvaloresExtra;
            PrecioOrden = Porden[0];
        }
        public float CalcularPrecioTotal() {
            aplicarDescuento();
            aplicarCargosEnvio();
            aplicarImpuestos();
            
            return PrecioOrden;
        }
        private void aplicarDescuento() {
            PrecioOrden -= Orden[1];
        }
        private void aplicarCargosEnvio() {
            PrecioOrden += ValoresExtra.GastoEnvio;
        }
        private void aplicarImpuestos() {
            PrecioOrden *= ValoresExtra.Impuesto;
        }
    }
}
