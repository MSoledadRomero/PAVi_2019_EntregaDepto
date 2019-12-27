using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    public class EstadoDetallePrestamo
    {
        private int idEstadoDetalle;
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdEstadoDetalle { get => idEstadoDetalle; set => idEstadoDetalle = value; }
    }
}
