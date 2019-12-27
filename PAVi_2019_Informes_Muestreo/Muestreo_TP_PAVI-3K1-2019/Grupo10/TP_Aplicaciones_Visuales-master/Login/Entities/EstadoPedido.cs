using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class EstadoPedido
    {
        private int idEstadoPedido;
        private string nombre;

        public int IdEstadoPedido { get => idEstadoPedido; set => idEstadoPedido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
