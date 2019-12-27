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
    class GeneroDAO : AbstractDataAccess
    {
       
        public IList<Genero> getAll()
        {
            List<Genero> listadoGenero = new List<Genero>();
            var consulta = "SELECT idGenero, nombre FROM Genero WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoGenero.Add(mapping(row));
            }

            return listadoGenero;
        }
        public DataTable getAllInTable()
        {
            var consulta = "SELECT idGenero AS 'Código Genero', nombre AS 'Nombre' FROM Genero WHERE borrado=0";
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
        }
        public Genero mapping(DataRow row)
        {
            Genero oGenero = new Genero();
            oGenero.IdGenero = Convert.ToInt32(row["idGenero"].ToString());
            oGenero.Nombre = row["nombre"].ToString();

            return oGenero;
        }


        public Genero obtenerGeneroSinParametros(int id)
        {
            String sql = string.Concat("SELECT idGenero, nombre ",
                                        "FROM Genero WHERE idGenero=" + id + " AND borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }



        public Genero obtenerGeneroConParametros(int id)
        {
            String sql = string.Concat("SELECT idGenero, nombre ",
                                        "FROM Genero WHERE idGenero=@id AND borrado=0");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }



        public DataTable obtenerGeneroConParametros(Dictionary<string, object> parametros)
        {

            String sql = string.Concat("SELECT  idGenero, nombre  ",
                                        "FROM Genero WHERE borrado = 0 ");

            if (parametros.ContainsKey("idGenero"))
            {
                sql += " AND idGenero = @idGenero ";
            }
            if (parametros.ContainsKey("nombre"))
            {
                sql += " AND nombre = @nombre";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

            return resultado;
        }
        /*
        public Genero getGenero(int id)
        {
            var dt = DBConexion.GetDBConexion().ConsultaSQL("select * from Genero where idGenero=" + id);
            return Mapping(dt.Rows[0]);
        }*/




        // Operaciones CRUD

        public bool insert(Genero oGenero)
        {
            string sql = @"INSERT INTO Genero (nombre) 
                VALUES('" + oGenero.Nombre +
           "')";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }


        public bool update(Genero oGenero)
        {
            string sql = @"UPDATE Genero " +
                "SET nombre='" + oGenero.Nombre + "' " +
                " WHERE idGenero=" + oGenero.IdGenero + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Genero oGenero)
        {
            string sql = @"UPDATE Genero SET borrado=1 WHERE idGenero=" + oGenero.IdGenero + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Genero SET borrado=1 WHERE idGenero=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }
    }
}
