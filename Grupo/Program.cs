using Classes;

namespace Grupo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();

            Console.WriteLine("Ingresa la cedula");
            int.TryParse(Console.ReadLine(), out int cedula);

            Console.WriteLine("Ingresa el nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el telefono");
            string telefono = Console.ReadLine();

            try
            {
                sistema.agregarCliente(cedula, nombre, telefono);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
