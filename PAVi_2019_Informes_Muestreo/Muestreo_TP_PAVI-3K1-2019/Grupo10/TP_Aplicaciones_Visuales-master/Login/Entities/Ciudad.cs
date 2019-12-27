using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class Ciudad
    {
        private int idCiudad;
        private string nombre;

        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Ciudad))
            {
                Ciudad oCiudad = (Ciudad)obj;
                if (oCiudad.Nombre == this.Nombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
