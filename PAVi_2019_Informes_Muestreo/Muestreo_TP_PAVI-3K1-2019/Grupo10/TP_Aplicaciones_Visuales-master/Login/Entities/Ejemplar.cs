using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    public class Ejemplar
    {
        public Ejemplar(int idEjemplar, int idLibro)
        {
            this.idLibro = idLibro;
            this.idEjemplar = idEjemplar;
        }
        public Ejemplar()
        {
        }
        private int idEjemplar;
        private int idLibro;
        private int idEstadoEjemplar;

        public int IdEjemplar { get => idEjemplar; set => idEjemplar = value; }
        public int IdLibro { get => idLibro; set => idLibro = value; }
        public int IdEstadoEjemplar { get => idEstadoEjemplar; set => idEstadoEjemplar = value; }

       

    }
}
