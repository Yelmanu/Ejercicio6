using Ejercicio6.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Servicios
{
    internal interface operacionesInterfaz
    {
        /// <summary>
        /// Metodo para dar el alta a los clientes
        /// 190124 -> MDN
        /// </summary>
        /// <param name="listaClientes"></param>
        public void darAltaCliente(List<clienteDto> listaCliente);
        /// <summary>
        /// Metodo para ordenar la lista de los clientes
        /// 190124 -> MDN
        /// </summary>
        /// <param name="listaClientes"></param>
        public void ordenarListaCLiente(List<clienteDto> listaCliente);
    }
}
