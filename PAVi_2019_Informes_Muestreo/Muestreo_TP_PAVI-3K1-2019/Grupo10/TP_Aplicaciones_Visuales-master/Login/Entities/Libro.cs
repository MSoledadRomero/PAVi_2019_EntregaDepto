using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TP_Aplicaciones_Visuales.Entities
{
    public class Libro
    {

        public int IdLibro { get ; set ; }
        public string Titulo { get ; set ; }
        public int AñoEdicion { get ; set ; }
        public int IdGenero { get; set; }
        public int IdAutor { get; set; }
        public int IdEditorial { get; set; }
        public string Sector { get; set; }
        public int Estante { get; set; }
        internal List<Ejemplar> Ejemplares { get; set; }
        public override string ToString()
        {
            return Titulo;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Libro))
            {
                Libro oLibro = (Libro)obj;
                if (oLibro.Titulo==this.Titulo && oLibro.AñoEdicion==this.AñoEdicion && oLibro.IdGenero==this.IdGenero && oLibro.IdEditorial==this.IdEditorial && oLibro.IdAutor==this.IdAutor)
                {
                    return true;
                }
            }
            return false;
        }



    }
}
 
