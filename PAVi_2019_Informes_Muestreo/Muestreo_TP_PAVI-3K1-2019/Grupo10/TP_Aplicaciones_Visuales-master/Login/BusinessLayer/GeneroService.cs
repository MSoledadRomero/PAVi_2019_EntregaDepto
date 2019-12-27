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
    class GeneroService
    {
        private GeneroDAO oGeneroDAO;
        public GeneroService()
        {
            oGeneroDAO = new GeneroDAO();
        }
        public IList<Genero> obtenerTodos()
        {
            return oGeneroDAO.getAll();
        }
        public DataTable obtenerTodosPorTabla()
        {
            return oGeneroDAO.getAllInTable();
        }
        public DataTable obtenerGeneros(string nombreProcedimiento)
        {
            return oGeneroDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public Genero obtenerGeneroSinParametros(int id)
        {
            return oGeneroDAO.obtenerGeneroSinParametros(id);
        }

        public Genero obtenerGeneroConParametros(int id)
        {
            return oGeneroDAO.obtenerGeneroConParametros(id);
        }

        public DataTable obtenerGenerosConParametros(Dictionary<string, object> parametros)
        {
            return oGeneroDAO.obtenerGeneroConParametros(parametros);
        }


        public bool existeGenero(Genero oGenero)
        {
            IList<Genero> generos = new List<Genero>();
            generos = oGeneroDAO.getAll();
            foreach (Genero a in generos)
            {
                if (oGenero.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }

        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oGeneroDAO.ObtenerUltimo("idGenero", "Genero"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }

        public bool insertarGenero(Genero oGenero)
        {
            return oGeneroDAO.insert(oGenero);
        }

        public bool actualizarGenero(Genero oGenero)
        {
            return oGeneroDAO.update(oGenero);
        }

        public bool darDeBajaGenero(int id)
        {
            return oGeneroDAO.logicalDelete(id);
        }

        public bool darDeBajaGenero(Genero oGenero)
        {
            return oGeneroDAO.logicalDelete(oGenero);
        }

    }
}
