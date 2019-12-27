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
    class PrestamoService
    {
        private PrestamoDAO oPrestamoDAO;
        public PrestamoService()
        {
            oPrestamoDAO = new PrestamoDAO();
        }
        public bool update (Prestamo oPrestamo)
        {
            return oPrestamoDAO.update(oPrestamo);
        }

        public DataTable obtenerPrestamoConParametros(Dictionary<String, object> parametros)
        {
            return oPrestamoDAO.obtenerPrestamoConParametros(parametros);
        }

        public bool insert(Prestamo oPrestamo)
        {
            return oPrestamoDAO.insert(oPrestamo);
        }
        public Prestamo obtenerPorIDSocio(int id)
        {
            return oPrestamoDAO.obtenerPorIDSocio(id);
        }
        public Prestamo obtenerPorIDPrestamo(int id)
        {
            return oPrestamoDAO.obtenerPorIDPrestamo(id);
        }


        internal bool create(Prestamo prestamo)
        {
            return oPrestamoDAO.create(prestamo);
        }
        internal bool ValidarDatos(Prestamo prestamo)
        {
            throw new Exception("debe ingresar al menos un libro.");
        }

    }
}
