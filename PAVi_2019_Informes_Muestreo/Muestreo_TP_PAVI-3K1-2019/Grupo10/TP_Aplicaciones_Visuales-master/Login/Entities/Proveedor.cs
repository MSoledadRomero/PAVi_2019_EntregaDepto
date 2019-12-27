using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    public class Proveedor
    {

        public int IdProveedor { get; set; }
        public int IdBarrio { get; set; }
        public string RazonSocial { get; set; }
        public int Telefono { get; set; }
        public string Mail { get ; set; }
        public string Calle { get; set; }
        public int NroCalle { get; set; }
      
        
        public override string ToString()
        {
            return RazonSocial;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Proveedor))
            {
                Proveedor oProveedor = (Proveedor)obj;
                if (oProveedor.RazonSocial == this.RazonSocial)
                {
                    return true;
                }
            }
            return false;
        }

 
    }
}

