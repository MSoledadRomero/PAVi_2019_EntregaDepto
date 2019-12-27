using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class Barrio
    {
        private int idBarrio;
        private int idCiudad;
        private string nombre;

        public int IdBarrio { get => idBarrio; set => idBarrio = value; }
        public int IdCiudad { get => idCiudad; set => idCiudad = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return Nombre;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Barrio))
            {
                Barrio oBarrio = (Barrio)obj;
                if (oBarrio.Nombre == this.Nombre && oBarrio.idCiudad==this.idCiudad)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
