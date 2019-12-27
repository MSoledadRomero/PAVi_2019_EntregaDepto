using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class TipoDocumento
    {
        private int idTipoDoc;
        private string nombre;

        public int IdTipoDoc { get => idTipoDoc; set => idTipoDoc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public override string ToString()
        {
            return "Tipo de Documento: " + nombre;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(TipoDocumento))
            {
                TipoDocumento oTipoDocumento = (TipoDocumento)obj;
                if (oTipoDocumento.Nombre == this.Nombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
