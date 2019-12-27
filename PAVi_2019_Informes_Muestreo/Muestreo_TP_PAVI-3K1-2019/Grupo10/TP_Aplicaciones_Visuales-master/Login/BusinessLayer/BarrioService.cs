using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.DataAccess;
using TP_Aplicaciones_Visuales.Entities;
using System.Data;

namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    class BarrioService
    {
        private BarrioDAO oBarrioDAO;

        public BarrioService()
        {
            oBarrioDAO = new BarrioDAO();
        }

        public IList<Barrio> obtenerTodos()
        {
            return oBarrioDAO.getAll();
        }

        public DataTable obtenerTodosPorTabla()
        {
            return oBarrioDAO.getAllInTable();
        }

        public DataTable obtenerBarrios(string nombreProcedimiento)
        {
            return oBarrioDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public bool existeBarrio(Barrio oBarrio)
        {
            IList<Barrio> barrios = new List<Barrio>();
            barrios = oBarrioDAO.getAll();
            foreach (Barrio a in barrios)
            {
                if (oBarrio.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }

        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oBarrioDAO.ObtenerUltimo("idBarrio", "Barrio"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }

        public Barrio obtenerBarriosSinParametros(int id)
        {
            return oBarrioDAO.obtenerBarrioSinParametros(id);
        }

        public Barrio obtenerBarriosConParametros(int id)
        {
            return oBarrioDAO.obtenerBarrioConParametros(id);
        }

        public DataTable obtenerBarriosConParametros(Dictionary<string, object> parametros)
        {
            return oBarrioDAO.obtenerBarrioConParametros(parametros);
        }







        public bool insertarBarrio(Barrio oBarrio)
        {
            return oBarrioDAO.insert(oBarrio);
        }

        public bool actualizarBarrio(Barrio oBarrio)
        {
            return oBarrioDAO.update(oBarrio);
        }

        public bool darDeBajaBarrio(int id)
        {
            return oBarrioDAO.logicalDelete(id);
        }

        public bool darDeBajaBarrio(Barrio oBarrio)
        {
            return oBarrioDAO.logicalDelete(oBarrio);
        }


    }
}
