using Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Contrato
    {
        private Cliente _cliente;
        private Excursion _excursion;
        private int _cantidadPasajeros;
        private int _cantMenores;
        private decimal _precio;

        public Contrato(
            Cliente cliente,
            Excursion excursion,
            int cantidadPasajeros,
            int cantMenores,
            decimal precio
            )
        {
            _cliente = cliente;
            _excursion = excursion;
            _cantMenores = cantidadPasajeros;
            _cantidadPasajeros = cantidadPasajeros;
            _precio = precio;
        }
    }
}
