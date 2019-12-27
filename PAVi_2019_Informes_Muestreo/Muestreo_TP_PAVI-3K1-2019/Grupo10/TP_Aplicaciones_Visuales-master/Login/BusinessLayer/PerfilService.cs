using TP_Aplicaciones_Visuales.DataAccess;
using TP_Aplicaciones_Visuales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    class PerfilService
    {
        private PerfilDAO oPerfilDAO;
        public PerfilService()
        {
            oPerfilDAO = new PerfilDAO();
        }
        public IList<Perfil> ObtenerTodos()
        {
            return oPerfilDAO.getAll();
        }


        public DataTable obtenerPerfiles(string nombreProcedimiento)
        {
            return oPerfilDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public Perfil obtenerPerfilSinParametros(int id)
        {
            return oPerfilDAO.obtenerPerfilSinParametros(id);
        }

        public Perfil obtenerPerfilConParametros(int id)
        {
            return oPerfilDAO.obtenerPerfilConParametros(id);
        }

        public DataTable obtenerPerfilConParametros(Dictionary<string, object> parametros)
        {
            return oPerfilDAO.obtenerPerfilConParametros(parametros);
        }

        public bool existePerfil(Perfil oPerfil)
        {
            IList<Perfil> perfiles = new List<Perfil>();
            perfiles = oPerfilDAO.getAll();
            foreach (Perfil a in perfiles)
            {
                if (oPerfil.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }
        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oPerfilDAO.ObtenerUltimo("idPerfil", "Perfil"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }

        public bool insertarPerfil(Perfil oPerfil)
        {
            return oPerfilDAO.insert(oPerfil);
        }

        public bool actualizarPerfil(Perfil oPerfil)
        {
            return oPerfilDAO.update(oPerfil);
        }

        public bool darDeBajaPerfil(int id)
        {
            return oPerfilDAO.logicalDelete(id);
        }

        public bool darDeBajaPerfil(Perfil oPerfil)
        {
            return oPerfilDAO.logicalDelete(oPerfil);
        }


    }
}
