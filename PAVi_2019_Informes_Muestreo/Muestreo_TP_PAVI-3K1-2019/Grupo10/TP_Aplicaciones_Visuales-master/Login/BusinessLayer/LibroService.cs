using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_Aplicaciones_Visuales.DataAccess;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    class LibroService
    {
        private LibroDAO oLibroDAO;

        public LibroService()
        {
            oLibroDAO = new LibroDAO();
        }

        public IList<Libro> obtenerTodos()
        {
            return oLibroDAO.getAll();
        }
        public DataTable obtenerTodosPorTabla()
        {
            return oLibroDAO.getAllInTable();
        }
        public DataTable obtenerLibros(string nombreProcedimiento)
        {
            return oLibroDAO.excecuteStoreProcedure(nombreProcedimiento);

        }

        public int ObtenerUltimoId()
        {
            return Convert.ToInt32((oLibroDAO.ObtenerUltimo("idLibro", "Libro"))); //Convierto a int el id 

        }

        public int ObtenerProximoId()
        {
            int idProx = ObtenerUltimoId();
            return idProx++;
        }

        public bool existeLibro(Libro oLibro)
        {
            IList<Libro> libros = new List<Libro>();
            libros = oLibroDAO.getAll();
            foreach (Libro a in libros)
            {
                if (oLibro.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }

        public DataTable obtenerLibrosConParametros(Dictionary<string,object> parametros)
        {
            return oLibroDAO.obtenerLibroConParametros(parametros);
        }

        public Libro obtenerLibrosConParametros(int id)
        {
            return oLibroDAO.obtenerLibroConParametros(id);
        }

        public Libro obtenerLibroSinParametros(int id)
        {
            return oLibroDAO.obtenerLibroSinParametros(id);
        }
        

        public bool insertarNuevoLibro(List<Ejemplar> ejemplares,Libro oLibro)
        {
            return oLibroDAO.insert(ejemplares, oLibro);
        }

        public bool insertarNuevoLibro(Libro oLibro)
        {
            return oLibroDAO.insert(oLibro);
        }

        public bool actualizarLibro(List<Ejemplar> ejemplares, Libro oLibro)
        {
            return oLibroDAO.updateAndInsertEjemplares(ejemplares, oLibro);
        }

        public bool actualizarLibro(Libro oLibro)
        {
            return oLibroDAO.update(oLibro);
        }

       
        public bool darDeBajaLibro(Libro oLibro)
        {
            return oLibroDAO.logicalDelete(oLibro);
        }

        public bool darDeBajaLibro(int id)
        {
            return oLibroDAO.logicalDelete(id);
        }
        
      
    }
}
