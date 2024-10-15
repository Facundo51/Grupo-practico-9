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

        public Cliente Cliente { get { return _cliente } }
        public Excursion Excursion { get { return _excursion } }
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
            _cantMenores = cantMenores;
            _cantidadPasajeros = cantidadPasajeros;
            _precio = precio;
        }

        public override bool Equals(Contrato? obj)
        {
            bool res = false;
            if (obj is Contrato )
            {
                return ((_cliente == obj.Cliente) &&(_excursion == obj.Excursion));
            }
            return res;
        }
    }
}
