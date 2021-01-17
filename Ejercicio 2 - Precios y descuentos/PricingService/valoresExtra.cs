using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingService {
    public class valoresExtra {
        private float _impuesto;
        public float Impuesto {
            get => _impuesto;
            // ()
            set => _impuesto = 1 + (value / 100);
        }
        private float _gastoEnvio;
        public float GastoEnvio {
            get => _gastoEnvio;
            set => _gastoEnvio = value;
        }
        public valoresExtra(float Pimpuesto, float PgastoEnvio) {
            Impuesto = Pimpuesto;
            GastoEnvio = PgastoEnvio;
        }
    }
}
