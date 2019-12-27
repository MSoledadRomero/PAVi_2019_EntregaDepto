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
    class EstadoPrestamoService
    {
        EstadoPrestamoDAO OEstadoPrestamoDAO;
        public EstadoPrestamoService()
        {
            OEstadoPrestamoDAO = new EstadoPrestamoDAO();
        }

        public IList<EstadoPrestamo> getAll()
        {
            return OEstadoPrestamoDAO.getAll();
        }


        public DataTable obtenerTodos()
        {
            return OEstadoPrestamoDAO.obtenerTodos();
        }

    }
}
