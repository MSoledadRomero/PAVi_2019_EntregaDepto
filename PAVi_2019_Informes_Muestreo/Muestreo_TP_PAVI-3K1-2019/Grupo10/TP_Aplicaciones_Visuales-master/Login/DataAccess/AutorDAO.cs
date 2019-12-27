using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_Aplicaciones_Visuales.Entities;
using TP_Aplicaciones_Visuales.AbstractClass;


namespace TP_Aplicaciones_Visuales.DataAccess
{
    class AutorDAO : AbstractDataAccess
    {
        
        
        
        /*public IList<Autor> GetAll()
        {
            List<Autor> listadoAutor = new List<Autor>();
            var consulta = "SELECT idAutor, nombre FROM Autor WHERE borrado=0"; //Todo: agregar el campo borrado a todas las tablas de la BD
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach(DataRow row in resultado.Rows)
            {
                listadoAutor.Add(Mapping(row));
            }

            return listadoAutor;
        }

        public Autor Mapping(DataRow row)
        {
            Autor oAutor= new Autor();
            oAutor.IdAutor = Convert.ToInt32(row["idAutor"].ToString());
            oAutor.Nombre = row["nombre"].ToString();

            return oAutor;
        }

        public Autor obtenerAutorSinParametros(int id)
        {
            string sql = string.Concat("SELECT A.idAutor as ID, A.nombre as Nombre",
                                        " FROM Autor A WHERE A.idAutor=" + id + " AND A.borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return Mapping(resultado.Rows[0]);
            }
            return null;
        }

        public IList<Autor> obtenerAutorConParametros(int idAutor)
        {
            List<Autor> autores = new List<Autor>();
            String sql = string.Concat("SELECT A.idAutor AS ID, A.nombre as Nombre",
                                        " FROM Autor A WHERE A.idAutor = @id AND A.borrado=0");
                                             
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", idAutor);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                autores.Add(Mapping(resultado.Rows[0]));
                return autores;
            }
            return null;

        }
        

        public IList<Autor> obtenerAutorConParametros(Dictionary<string, object> parametros)
        {
            List<Autor> autores = new List<Autor>();
            String sql = string.Concat("SELECT A.idAutor AS ID, A.nombre as Nombre",
                                        " FROM Autor A WHERE A.idAutor = @id AND A.borrado=0");

            if (parametros.ContainsKey("nombre"))
            {
                sql += " AND A.nombre = @nombre";
            }

            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            foreach (DataRow row in resultado.Rows)
            {
                autores.Add(Mapping(row));
                return autores;
            }
            return null;
        }

        public DataTable obtenerAutorConParametros(Dictionary<string, object> parametros)
        {
            List<Autor> autores = new List<Autor>();
            String sql = string.Concat("SELECT A.idAutor AS ID, A.nombre as Nombre",
                                        " FROM Autor A WHERE A.idAutor = @id AND A.borrado=0");

            if (parametros.ContainsKey("nombre"))
            {
                sql += " AND A.nombre = @nombre";
            }

            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            return resultado;
        }*/

        //obtiene todos los autores devolviendolos en un list
        public IList<Autor> getAll()
        {
            List<Autor> listadoAutor = new List<Autor>();
            var consulta = "SELECT idAutor, nombre FROM Autor WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoAutor.Add(mapping(row));
            }

            return listadoAutor;
        }

        public DataTable getAllInTable()
        {
            var consulta = "SELECT idAutor AS 'Código autor' , nombre AS Autor FROM Autor WHERE borrado=0";
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
        }

        //Mapea de modelo relacional a objeto

        public Autor mapping(DataRow row)
        {
            Autor oAutor = new Autor();
            oAutor.IdAutor = Convert.ToInt32(row["idAutor"].ToString());
            oAutor.Nombre = row["nombre"].ToString();

            return oAutor;
        }
        
        public Autor obtenerAutorSinParametros(int id)
        {
            String sql = string.Concat("SELECT idAutor, nombre ",
                                        "FROM Autor WHERE idAutor=" + id + " borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

        //Este se usa para no tener que crear el diccionario y no tener que usar la consulta sin arametros
        public Autor obtenerAutorConParametros(int id)
        {
            String sql = string.Concat("SELECT idAutor, nombre ",
                                        "FROM Autor WHERE idAutor=@id AND borrado=0");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }









        //TODO: VER PARA QUE SE USA Y SI CONVIENE UN DATATABLE O LIST
        public DataTable obtenerAutorConParametros(Dictionary<string, object> parametros)
        {
            //List<Autor> autores = new List<Autor>();
            String sql = string.Concat("SELECT idAutor, nombre ",
                                        "FROM Autor WHERE borrado=0");

            if (parametros.ContainsKey("idAutor"))
            {
                sql += " AND idAutor = @idAutor ";
            }
            if (parametros.ContainsKey("nombre"))
            {
                sql += " AND nombre = @nombre";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

            //foreach (DataRow row in resultado.Rows)
            //{
            //    autores.Add(mapping(row));
            //    return autores;
            //}

            return resultado;
        }

        // Operaciones CRUD

        public bool insert(Autor oAutor)
        {
            string sql = @"INSERT INTO Autor (nombre) VALUES ('" + oAutor.Nombre + "')";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool update(Autor oAutor)
        {
            string sql = @"UPDATE Autor SET nombre='" + oAutor.Nombre + "' "+
                        "WHERE idAutor="+oAutor.IdAutor+" AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Autor oAutor)
        {
            string sql = @"UPDATE Autor SET borrado=1 WHERE idAutor="+oAutor.IdAutor+" AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Autor SET borrado=1 WHERE idAutor=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }
    }
}
