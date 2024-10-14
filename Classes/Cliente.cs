
namespace Grupo
{
    public class Cliente
    {
        private int _cedula;
        private string _nombre;
        private string _telefono;

        public Cliente(
            int cedula,
            string nombre,
            string telefono
            )
        {
            _cedula = cedula;
            _nombre = nombre;
            _telefono = telefono;

            Validar();
        }

        public void Validar()
        {
            if ( _telefono == "" || _cedula <= 0 || _nombre == "" )
            {
                throw new Exception("Los campos no pueden estar vacios");
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj is Cliente cliente)
            {
                return _cedula == cliente.ObtenerCedula();
            }

            return false;
        }

        public int ObtenerCedula()
        {
            return _cedula;
        }
    }
}
