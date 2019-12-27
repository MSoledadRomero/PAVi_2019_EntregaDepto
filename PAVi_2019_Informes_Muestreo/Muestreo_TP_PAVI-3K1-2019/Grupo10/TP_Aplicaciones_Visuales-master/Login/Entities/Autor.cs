using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class Autor
    {
        private int idAutor;
        private string nombre;

        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Autor))
            {
                Autor oAutor = (Autor)obj;
                if(oAutor.Nombre == this.Nombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
