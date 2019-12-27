using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class DetallePedido
    {
        private int idPedido;
        private int idEjemplar;
        private int idLibro;
        private int cantidad;
        private double precio; //double?

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int IdEjemplar { get => idEjemplar; set => idEjemplar = value; }
        public int IdLibro { get => idLibro; set => idLibro = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
