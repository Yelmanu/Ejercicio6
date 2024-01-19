using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Servicios
{
    internal class menuImplementacion : menuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("0. Cerrar Menú");
            Console.WriteLine("1. Añadir Cliente");
            Console.WriteLine("2. Ordenar Clientes");

            opcionSeleccionada = Console.ReadKey(true).KeyChar - ('0');
            return opcionSeleccionada;
        }
    }
}
