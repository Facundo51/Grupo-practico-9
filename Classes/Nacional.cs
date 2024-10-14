using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Nacional : Excursion
    {
        private int _maxPasajeros;
        private decimal _descuento;

        public Nacional(
            string codig, 
            string descripcion, 
            DateTime fechaComienzo, 
            int dias, 
            decimal costo, 
            int maxPasajeros, 
            decimal descuento
            ) : base(codig, descripcion, fechaComienzo, dias, costo)
        {
            _maxPasajeros = maxPasajeros;
            _descuento = descuento;
        }
    }
}
