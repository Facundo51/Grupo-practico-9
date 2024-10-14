using Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classes
{
    public class Sistema
    {

        private List<Cliente>  _clientes;
        private List<Excursion> _excursiones;
        private List<Contrato> _contratos;

        public void agregarCliente(int ci, string nombre, string telefono)
        {
             Cliente nuevo = new Cliente(ci, nombre, telefono); 
                if(!(_clientes.Contains(nuevo)))
                {
                    _clientes.Add(nuevo);
                }
        }
    

        public void PrecargarNacionales()
        {
            Nacional nuevo = new Nacional("A123","La Bumba", new DateTime(2025,11,15),10,15.3M,100,5.1M);
            if (!(_excursiones.Contains(nuevo)))
            {
                _excursiones.Add(nuevo);
            }
        }
        public void PrecargarExtranjero()
        {
            Extranjero nuevo = new Extranjero("B123", "Big Apple", new DateTime(2025, 11, 15), 10, 20, true, 2.1m);
            if (!(_excursiones.Contains(nuevo)))
            {
                _excursiones.Add(nuevo);
            }
        }

        public List<Contrato> ObtenerContratosDeCLiente(Cliente cliente)
        {
            List<Contrato> contratos = new List<Contrato>();

            foreach (Contrato contrato in _contratos)
            {
                if (contrato.Cliente.Cedula == cliente.Cedula)
                {
                    contratos.Add(contrato);
                }
            }

            return contratos;
        }

        public List<Excursion> BuscarExcursionesPorFecha(DateTime fecha1, DateTime fecha2)
        {
            List<Excursion> excursiones = new List<Excursion>();

            foreach(Excursion excursion in _excursiones)
            {
                if (excursion.FechaComienzo > fecha1 && excursion.FechaComienzo < fecha2)
                {
                    excursiones.Add(excursion);
                }
            }

            return excursiones;
        }
    }
}
