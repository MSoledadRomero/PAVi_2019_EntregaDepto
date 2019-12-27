using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    public class DetalleCompra
    {

        public int Cantidad { get ; set;}
        public int IdDetalleCompra { get ; set ;}
        public int IdCompra { get; set;}
        public Libro Libro { get; set;}
    }
}
