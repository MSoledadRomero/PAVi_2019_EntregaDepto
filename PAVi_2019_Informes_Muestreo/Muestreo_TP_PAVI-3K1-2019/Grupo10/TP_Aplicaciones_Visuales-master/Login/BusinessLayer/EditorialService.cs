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
    class EditorialService
    {
        private EditorialDAO oEditorialDAO;

        public EditorialService()
        {
            oEditorialDAO = new EditorialDAO();
        }

        public IList<Editorial> obtenerTodos()
        {
            return oEditorialDAO.getAll();
        }
        public DataTable obtenerTodosPorTabla()
        {
            return oEditorialDAO.getAllInTable();
        }

        public DataTable obtenerEditoriales(string nombreProcedimiento)
        {
            return oEditorialDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public Editorial obtenerEditorialSinParametros(int id)
        {
            return oEditorialDAO.obtenerEditorialSinParametros(id);
        }

        public Editorial obtenerEditorialConParametros(int id)
        {
            return oEditorialDAO.obtenerEditorialConParametros(id);
        }

        public DataTable obtenerEditorialConParametros(Dictionary<string, object> parametros)
        {
            return oEditorialDAO.obtenerEditorialConParametros(parametros);
        }

        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oEditorialDAO.ObtenerUltimo("idEditorial", "Editorial"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }


        public bool existeEditorial(Editorial oEditorial)
        {
            IList<Editorial> editoriales = new List<Editorial>();
            editoriales = oEditorialDAO.getAll();
            foreach (Editorial a in editoriales)
            {
                if (oEditorial.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }




        public bool insertarEditorial(Editorial oEditorial)
        {
            return oEditorialDAO.insert(oEditorial);
        }

        public bool actualizarEditorial(Editorial oEditorial)
        {
            return oEditorialDAO.update(oEditorial);
        }

        public bool darDeBajaEditorial(int id)
        {
            return oEditorialDAO.logicalDelete(id);
        }

        public bool darDeBajaEditorial(Editorial oEditorial)
        {
            return oEditorialDAO.logicalDelete(oEditorial);
        }
    }
}
