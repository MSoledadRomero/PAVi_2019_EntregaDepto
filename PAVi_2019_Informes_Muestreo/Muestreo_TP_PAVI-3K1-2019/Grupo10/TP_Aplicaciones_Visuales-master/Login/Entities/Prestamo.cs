using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    public class Prestamo
    {
        private int idPrestamo;
        private int idSocio;
        private int idEstadoPrestamo;
        private DateTime fechaPrestamo;
        private DateTime fechaLimite;
        private IList<DetallePrestamo> listaDeDetalles;

        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public int IdSocio { get => idSocio; set => idSocio = value; }
        public int IdEstadoPrestamo { get => idEstadoPrestamo; set => idEstadoPrestamo = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaLimite { get => fechaLimite; set => fechaLimite = value; }
        public IList<DetallePrestamo> ListaDeDetalles { get => listaDeDetalles; set => listaDeDetalles = value; }
    }
}
