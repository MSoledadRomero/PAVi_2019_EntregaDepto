using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.Entities;
using TP_Aplicaciones_Visuales.DataAccess;
using System.Data;

namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    class EstadoEjemplarService
    {
        private EstadoEjemplarDAO oEstadoEjemplarDAO;

        public EstadoEjemplarService()
        {
            oEstadoEjemplarDAO = new EstadoEjemplarDAO();
        }

        public IList<EstadoEjemplar> obtenerTodos()
        {
            return oEstadoEjemplarDAO.getAll();
        }

        public DataTable obtenerEstadoEjemplar(string nombreProcedimiento)
        {
            return oEstadoEjemplarDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public EstadoEjemplar obtenerEstadoEjemplarSinParametros(int id)
        {
            return oEstadoEjemplarDAO.obtenerEstadoEjemplarSinParametros(id);
        }

        public EstadoEjemplar obtenerEstadoEjemplarSinParametros(string nombre)
        {
            return oEstadoEjemplarDAO.obtenerEstadoEjemplarSinParametros(nombre);
        }



        public bool existeEstadoEjemplar(EstadoEjemplar oEstadoEjemplar)
        {
            IList<EstadoEjemplar> estadosEjemplares = new List<EstadoEjemplar>();
            estadosEjemplares = oEstadoEjemplarDAO.getAll();
            foreach (EstadoEjemplar a in estadosEjemplares)
            {
                if (oEstadoEjemplar.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }

        public int obtenerUltimoId()
        {
            string id = oEstadoEjemplarDAO.ObtenerUltimo("idEstadoEjemplar", "EstadoEjemplar");
            if (id != "")
            {
                return Convert.ToInt32(id);
            }
                return 0;
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }

        public bool insertarEstadoEjemplar(EstadoEjemplar oEstadoEjemplar)
        {
            return oEstadoEjemplarDAO.insert(oEstadoEjemplar);
        }

        public bool actualizarEstadoEjemplar(EstadoEjemplar oEstadoEjemplar)
        {
            return oEstadoEjemplarDAO.update(oEstadoEjemplar);
        }

        public bool darDeBajaEstadoEjemplar(int id)
        {
            return oEstadoEjemplarDAO.logicalDelete(id);
        }

        public bool darDeBajaEstadoEjemplar(EstadoEjemplar oEstadoEjemplar)
        {
            return oEstadoEjemplarDAO.logicalDelete(oEstadoEjemplar);
        }






    }
}
