using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Dtos
{
    internal class clienteDto
    {
        long idCliente;
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        string nombreCompleto = "aaaaa";
        int edadCliente = 0;

        //Getters & Setters
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int EdadCliente { get => edadCliente; set => edadCliente = value; }

        //Constructores
        public clienteDto(long idCliente, string nombreCliente, string apellidosCliente, string nombreCompleto, int edadCliente)
        {
            this.IdCliente = idCliente;
            this.NombreCliente = nombreCliente;
            this.ApellidosCliente = apellidosCliente;
            this.NombreCompleto = nombreCompleto;
            this.EdadCliente = edadCliente;
        }

        public clienteDto()
        {
        }

        //ToString
        override
        public string ToString()
        {
            nombreCompleto = nombreCliente + " " + apellidosCliente;
            string concatenacion = nombreCompleto + " " + edadCliente;
            return concatenacion;
        }
    }
}
