using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class Genero
    {
        private int idGenero;
        private string nombre;

        public int IdGenero { get => idGenero; set => idGenero = value; }
        public string Nombre { get => nombre; set => nombre = value; }



        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Genero))
            {
                Genero oGenero = (Genero)obj;
                if (oGenero.Nombre == this.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
