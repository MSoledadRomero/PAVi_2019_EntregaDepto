using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    public class DetallePrestamo
    {
        private int idDetallePrestamo;
        private int idPrestamo;
        private int idEstadoDetallePrestamo;
        private int idEjemplar;
        private int idLibro;
        private DateTime fechaDevolucion;

        public int IdDetallePrestamo { get => idDetallePrestamo; set => idDetallePrestamo = value; }
        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public int IdEjemplar { get => idEjemplar; set => idEjemplar = value; }
        public int IdLibro { get => idLibro; set => idLibro = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public int IdEstadoDetallePrestamo { get => idEstadoDetallePrestamo; set => idEstadoDetallePrestamo = value; }

    }

}
