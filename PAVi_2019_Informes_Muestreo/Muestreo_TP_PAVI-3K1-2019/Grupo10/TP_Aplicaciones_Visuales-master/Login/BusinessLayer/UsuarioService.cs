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
    class UsuarioService
    {
        private UsuarioDAO oUsuarioDAO;
        public UsuarioService()
        {
            oUsuarioDAO = new UsuarioDAO();
        }
        public IList<Usuario> obtenerTodos()
        {
            return oUsuarioDAO.getAll();
        }
        public DataTable obtenerUsuarios(string nombreProcedimiento)
        {
            return oUsuarioDAO.excecuteStoreProcedure(nombreProcedimiento);

        }
        public bool validarUsuario(string nombre, string contraseña)
        {
            Usuario usuarioEncontrado = oUsuarioDAO.obtenerUsuarioConParametros(nombre);
            if (usuarioEncontrado.Contraseña == contraseña)
            {
                return true;
            }            
            return false;           
             
        }



        /*public IList<Usuario> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oUsuarioDAO.GetByFiltersSinParametros(condiciones);
        }*/

        public Usuario obtenerUsuarioSinParametros(int id)
        {
            return oUsuarioDAO.obtenerUsuarioSinParametros(id);
        }

        public Usuario obtenerUsuarioConParametros(int id)
        {
            return oUsuarioDAO.obtenerUsuarioConParametros(id);
        }

        public DataTable obtenerUsuarioConParametros(Dictionary<string, object> parametros)
        {
            return oUsuarioDAO.obtenerUsuarioConParametros(parametros);
        }

        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oUsuarioDAO.ObtenerUltimo("idUsuario", "Usuario"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }





        public bool existeUsuario(Usuario oUsuario)
        {
            IList<Usuario> usuarios = new List<Usuario>();
            usuarios = oUsuarioDAO.getAll();
            foreach (Usuario a in usuarios)
            {
                if (oUsuario.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }


        public bool InsertarUsuario(Usuario oUsuario)
        {
            return oUsuarioDAO.insert(oUsuario);
        }

        public bool ActualizarUsuario(Usuario oUsuarioSelected)
        {
            return oUsuarioDAO.update(oUsuarioSelected);
        }

        public bool darDeBajaUsuario(int id)
        {
            return oUsuarioDAO.logicalDelete(id);
        }

        public bool darDeBajaUsuario(Usuario oUsuario)
        {
            return oUsuarioDAO.logicalDelete(oUsuario);
        }



        /*
        internal bool ModificarEstadoUsuario(Usuario oUsuarioSelected)
        {
            return oUsuarioDAO.delete(oUsuarioSelected);
        }
        internal object ObtenerUsuario(string usuario)
        {
            return oUsuarioDAO.GetUserSinParametros(usuario);
        }*/
    }
}
