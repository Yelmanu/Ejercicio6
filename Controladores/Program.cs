using Ejercicio6.Dtos;
using Ejercicio6.Servicios;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<clienteDto> listaCliente = new List<clienteDto>();
            operacionesInterfaz oi = new operacionesImplementacion();
            menuInterfaz mi = new menuImplementacion();

            int opcionSeleccionada = 0;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenu();
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Ha seleccionado la opcion 0");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Ha seleccionado la opcion 1");
                        oi.darAltaCliente(listaCliente);
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado la opcion 2");
                        oi.ordenarListaCLiente(listaCliente);
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion del menu");
                        break;
                }
            }
        }
    }
}
