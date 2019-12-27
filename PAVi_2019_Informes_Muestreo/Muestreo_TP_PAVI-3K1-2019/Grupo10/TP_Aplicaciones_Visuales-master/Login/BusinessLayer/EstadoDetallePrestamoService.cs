using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.DataAccess;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    class EstadoDetallePrestamoService
    {
        EstadoDetallePrestamoDAO oEstadoDetallePrestamoDAO;
        public EstadoDetallePrestamoService()
        {
            oEstadoDetallePrestamoDAO = new EstadoDetallePrestamoDAO();
        }

        public DataTable obtenerTodos()
        {
            return oEstadoDetallePrestamoDAO.obtenerTodos();
        }
    }
}
