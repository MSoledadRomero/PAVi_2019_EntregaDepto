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
    class EjemplarService
    {
        private EjemplarDAO oEjemplarDAO;

        public EjemplarService()
        {
            oEjemplarDAO = new EjemplarDAO();
        }
     

        public IList<Ejemplar> obtenerTodos()
        {
            return oEjemplarDAO.getAll();
        }
        public Ejemplar mapear(DataRow r)
        {
            return oEjemplarDAO.mapping(r);
        }

        public DataTable obtenerEjemplar(string nombreProcedimiento)
        {
            return oEjemplarDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public DataTable obtenerEjemplaresPorLibro(int idLibro)
        {
            return oEjemplarDAO.obtenerEjemplaresPorLibro(idLibro);
        }

        public int ObtenerUltimoId()
        {
            string id = oEjemplarDAO.ObtenerUltimo("idEjemplar", "Ejemplar");
            if (id != "")
            {
                return Convert.ToInt32(id);
            }
            return 0;

        }

        public int ObtenerProximoId()
        {
            int idProx = ObtenerUltimoId();
            return idProx++;
        }

        
        

        public Ejemplar obtenerEjemplarSinParametros(int id)
        {
            return oEjemplarDAO.obtenerEjemplarSinParametros(id);
        }

        public Ejemplar obtenerEjemplarConParametros(int id)
        {
            return oEjemplarDAO.obtenerEjemplarConParametros(id);
        }

        public DataTable obtenerEjemplarConParametros(Dictionary<string, object> parametros)
        {
            return oEjemplarDAO.obtenerEjemplarConParametros(parametros);
        }




        public bool insertarEjemplar(Ejemplar oEjemplar)
        {
            return oEjemplarDAO.insert(oEjemplar);
        }

        public bool actualizarEjemplar(Ejemplar oEjemplar)
        {
            return oEjemplarDAO.update(oEjemplar);
        }

        public bool darDeBajaEjemplar(int id)
        {
            return oEjemplarDAO.logicalDelete(id);
        }

        public bool darDeBajaEjemplar(Ejemplar oEjemplar)
        {
            return oEjemplarDAO.logicalDelete(oEjemplar);
        }

    }
}
