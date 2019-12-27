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
    class AutorService
    {
        private AutorDAO oAutorDAO;
        public AutorService()
        {
            oAutorDAO = new AutorDAO();
        }

        public IList<Autor> obtenerTodos()
        {
            return oAutorDAO.getAll();
        }
        public DataTable obtenerTodosPorTabla()
        {
            return oAutorDAO.getAllInTable();
        }

        public DataTable obtenerAutores(string nombreProcedimiento)
        {
            return oAutorDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public Autor obtenerAutorSinParametros(int id)
        {
            return oAutorDAO.obtenerAutorSinParametros(id);
        }

        public Autor obtenerAutoresConParametros(int id)
        {
            return oAutorDAO.obtenerAutorConParametros(id);
        }

        public DataTable obtenerAutoresConParametros(Dictionary<string,object> parametros)
        {
            return oAutorDAO.obtenerAutorConParametros(parametros);
        }

        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oAutorDAO.ObtenerUltimo("idAutor","Autor"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }

              
        public bool existeAutor(Autor oAutor)
        {
            IList<Autor> autores = new List<Autor>();
            autores = oAutorDAO.getAll();
            foreach (Autor a in autores)
            {
                if (oAutor.Equals(a))
                {
                    return true;
                }
            }
                return false;           

        }

        


        public bool insertarAutor(Autor oAutor)
        {
            return oAutorDAO.insert(oAutor);
        }

        public bool actualizarAutor(Autor oAutor)
        {
            return oAutorDAO.update(oAutor);
        }

        public bool darDeBajaAutor(int id)
        {
            return oAutorDAO.logicalDelete(id);
        }

        public bool darDeBajaAutor(Autor oAutor)
        {
            return oAutorDAO.logicalDelete(oAutor);
        }

    }
}
