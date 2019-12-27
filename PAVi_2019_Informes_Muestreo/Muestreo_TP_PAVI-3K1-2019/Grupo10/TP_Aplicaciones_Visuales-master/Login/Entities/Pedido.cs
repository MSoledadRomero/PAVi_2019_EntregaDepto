using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class Pedido
    {
        private int idPedido;
        private int idEstadoPedido;
        private DateTime fechaPedido;
        private DateTime fechaRecepcion;

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int IdEstadoPedido { get => idEstadoPedido; set => idEstadoPedido = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaRecepcion { get => fechaRecepcion; set => fechaRecepcion = value; }
    }
}
