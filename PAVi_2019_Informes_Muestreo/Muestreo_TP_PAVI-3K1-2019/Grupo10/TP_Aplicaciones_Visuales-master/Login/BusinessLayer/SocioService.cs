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
    class SocioService
    {
        private static SocioDAO oSocioDAO;
        public SocioService()
        {
            oSocioDAO = new SocioDAO();
        }

        public IList<Socio> obtenerTodos()
        {
            return oSocioDAO.getAll();
        }
        public DataTable obtenerTodosPorTabla()
        {
            return oSocioDAO.getAllInTable();
        }

        public DataTable obtenerSocios(string nombreProcedimiento)
        {
            return oSocioDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public int ObtenerUltimoId()
        {
            return Convert.ToInt32((oSocioDAO.ObtenerUltimo("idSocio","Socio"))); //Convierto a int el id 
            
        }

        public int ObtenerProximoId()
        {
            int idProx=ObtenerUltimoId();
            return idProx++;
        }

        public bool existeSocio(Socio oSocio)
        {
            IList<Socio> socios = new List<Socio>();
            socios= oSocioDAO.getAll();
            foreach (Socio a in socios)
            {
                if (oSocio.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }


        public DataTable obtenerSocioConParametros(Dictionary<string,Object> parametros)
        {
            return oSocioDAO.obtenerSocioConParametros(parametros);
        }
        public Socio obtenerSocioSinParametros(int id)
        {
            return oSocioDAO.obtenerSocioSinParametros(id);
        }

        public bool insertarNuevoSocio(Socio oSocio)
        {
            return oSocioDAO.insert(oSocio);
        }

        public bool actualizarSocio(Socio oSocio)
        {
            return oSocioDAO.update(oSocio);
        }

        public bool darDeBajaSocio(Socio oSocio)
        {
            return oSocioDAO.logicalDelete(oSocio);
        }

        public bool darDeBajaSocio(int id)
        {
            return oSocioDAO.logicalDelete(id);
        }


     }
}
