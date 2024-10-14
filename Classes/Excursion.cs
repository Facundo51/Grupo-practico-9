using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Excursion
    {
        private string _codigo;
        private string _descripcion;
        private DateTime _fechaComienzo;
        private int _dias;
        private decimal _costo;

        public Excursion(
            string codig,
            string descripcion,
            DateTime fechaComienzo,
            int dias,
            decimal costo
            )
        {
            _codigo = codig;
            _descripcion = descripcion;
            _fechaComienzo = fechaComienzo;
            _dias = dias;
            _costo = costo;

            Validar();
        }

        public void Validar()
        {

        }
    }
}
