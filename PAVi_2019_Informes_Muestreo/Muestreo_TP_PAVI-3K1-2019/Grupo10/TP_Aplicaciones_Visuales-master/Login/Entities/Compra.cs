using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    public class Compra
    {
     
     
        public int IdCompra { get; set; }
        public DateTime FechaDeCompra { get; set; }
        public Proveedor OProveedor { get; set; }

        public int Borrado { get; set; }
        

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Compra))
            {
                Compra oCompra = (Compra)obj;
                if (oCompra.FechaDeCompra== this.FechaDeCompra && oCompra.OProveedor.IdProveedor == this.OProveedor.IdProveedor)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
