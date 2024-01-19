using Ejercicio6.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public void darAltaCliente(List<clienteDto> listaCliente)
        {
            clienteDto nuevoCliente = crearCliente();
            listaCliente.Add(nuevoCliente);
        }

        /// <summary>
        /// Metodo que pide al usuario la informacion para dar de alta un nuevo cliente
        ///  190124 - MDN
        /// </summary>
        /// <returns></returns>
        private clienteDto crearCliente()
        {
            clienteDto cliente = new clienteDto();
            Console.WriteLine("Introduce el id del cliente: ");
            cliente.IdCliente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del cliente: ");
            cliente.NombreCliente = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidos del cliente: ");
            cliente.ApellidosCliente = Console.ReadLine();
            Console.WriteLine("Introduzca la edad del cliente: ");
            cliente.EdadCliente = Convert.ToInt32(Console.ReadLine());
            return cliente;
        }

        public void ordenarListaCLiente(List<clienteDto> listaCliente)
        {
            int numClientes = listaCliente.Count;
            if (numClientes >= 3)
            {
                for (int fila = 0; fila < listaCliente.Count; fila++)
                {
                    for (int columna = 0; columna < listaCliente.Count - 1 - fila; columna++)
                    {
                        if (listaCliente[columna + 1].EdadCliente > listaCliente[columna].EdadCliente)
                        {
                            clienteDto aux = listaCliente[columna + 1];
                            listaCliente[columna + 1] = listaCliente[columna];
                            listaCliente[columna] = aux;
                        }
                    }
                }

                foreach (clienteDto cliente in listaCliente)
                {
                    Console.WriteLine(cliente.ToString());
                }
            }
            else
            {
                Console.WriteLine("[INFO] - No hay suficientes clientes para ordenar");
            }
        }
    }
}
