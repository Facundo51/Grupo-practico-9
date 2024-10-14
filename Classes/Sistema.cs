using Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           

        }
    }
