using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Extranjero : Excursion
    {
        private bool _pasaje;
        private decimal s_costoSecuro;

        public Extranjero(
            string codig, 
            string descripcion, 
            DateTime fechaComienzo, 
            int dias, 
            decimal costo,
            bool pasaje,
            decimal costoSeguro
            ) : base(codig, descripcion, fechaComienzo, dias, costo)
        {
            _pasaje = pasaje;
            s_costoSecuro = costoSeguro;
        }
    }
}
