using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class EstadoPrestamo
    {
        private int idEstadoPrestamo;
        private string nombre;

        public int IdEstadoPrestamo { get => idEstadoPrestamo; set => idEstadoPrestamo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
