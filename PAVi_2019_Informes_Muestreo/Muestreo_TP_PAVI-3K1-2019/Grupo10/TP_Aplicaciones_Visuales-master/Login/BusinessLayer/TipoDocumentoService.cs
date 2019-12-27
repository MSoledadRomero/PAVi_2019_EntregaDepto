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
    class TipoDocumentoService
    {
        private TipoDocumentoDAO oTipoDocumentoDAO;
        public TipoDocumentoService()
        {
            oTipoDocumentoDAO = new TipoDocumentoDAO();
        }
        public IList<TipoDocumento> obtenerTodos()
        {
            return oTipoDocumentoDAO.getAll();
        }

        public DataTable obtenerTodosPorTabla()
        {
            return oTipoDocumentoDAO.getAllInTable();
        }

        public DataTable obtenerTipoDocumentos(string nombreProcedimiento)
        {
            return oTipoDocumentoDAO.excecuteStoreProcedure(nombreProcedimiento);

        }
        public TipoDocumento obtenerTipoDocumentoConParametros(string nombre)
        {
            return oTipoDocumentoDAO.obtenerTipoDocumentoConParametros(nombre);
        }
        public TipoDocumento obtenerTipoDocumentoConParametros(int id)
        {
            return oTipoDocumentoDAO.obtenerTipoDocumentoConParametros(id);
        }
        public DataTable obtenerTipoDocumentoConParametros(Dictionary<string,object> parametros)
        {
            return oTipoDocumentoDAO.obtenerTipoDocumentoConParametros(parametros);
        }
        public bool existeTipoDocumento(TipoDocumento oTipoDocumento)
        {
            IList<TipoDocumento> tiposDoc = new List<TipoDocumento>();
            tiposDoc = oTipoDocumentoDAO.getAll();
            foreach (TipoDocumento a in tiposDoc)
            {
                if (oTipoDocumento.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }

        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oTipoDocumentoDAO.ObtenerUltimo("idTipoDoc", "TipoDocumento"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }

        public bool insertarTipoDocumento(TipoDocumento oTipoDocumento)
        {
            return oTipoDocumentoDAO.insert(oTipoDocumento);
        }

        public bool actualizarTipoDocumento(TipoDocumento oTipoDocumento)
        {
            return oTipoDocumentoDAO.update(oTipoDocumento);
        }

        public bool darDeBajaAutorTipoDocumento(int id)
        {
            return oTipoDocumentoDAO.logicalDelete(id);
        }

        public bool darDeBajaTipoDocumento(TipoDocumento oTipoDocumento)
        {
            return oTipoDocumentoDAO.logicalDelete(oTipoDocumento);
        }
    }
}
