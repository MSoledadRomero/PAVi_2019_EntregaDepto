using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class EstadoEjemplar
    {
        private int idEstadoEjemplar;
        private string nombre;

        public int IdEstadoEjemplar { get => idEstadoEjemplar; set => idEstadoEjemplar = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(EstadoEjemplar))
            {
                EstadoEjemplar oEstadoEjemplar = (EstadoEjemplar)obj;
                if (oEstadoEjemplar.Nombre == this.Nombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
