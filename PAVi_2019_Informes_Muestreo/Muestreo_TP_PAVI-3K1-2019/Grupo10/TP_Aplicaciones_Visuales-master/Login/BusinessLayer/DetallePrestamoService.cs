using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.DataAccess;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    
    class DetallePrestamoService

    {
        private DetallePrestamoDAO oDetallePrestamoDAO;
        public DetallePrestamoService()
        {
            oDetallePrestamoDAO = new DetallePrestamoDAO();
        }
        public IList<DetallePrestamo> getAllPorIDPrestamo(int id)
        {
            return oDetallePrestamoDAO.getAllPorIDPrestamo(id);
        }
    }
}
