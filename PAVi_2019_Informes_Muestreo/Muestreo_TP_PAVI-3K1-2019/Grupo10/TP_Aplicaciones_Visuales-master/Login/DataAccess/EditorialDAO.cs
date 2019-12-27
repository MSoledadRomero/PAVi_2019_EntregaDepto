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
    class EditorialDAO : AbstractDataAccess
    {
       
        public IList<Editorial> getAll()
        {
            List<Editorial> listadoEditorial = new List<Editorial>();
            var consulta = "SELECT idEditorial, nombreEditorial FROM Editorial WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoEditorial.Add(mapping(row));
            }

            return listadoEditorial;
        }

        public DataTable getAllInTable()
        {
            var consulta = "SELECT idEditorial AS 'Código Editorial' , nombreEditorial AS 'Nombre' FROM Editorial WHERE borrado=0";
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
        }

        public Editorial mapping(DataRow row)
        {
            Editorial oEditorial = new Editorial();
            oEditorial.IdEditorial = Convert.ToInt32(row["idEditorial"].ToString());
            oEditorial.NombreEditorial = row["nombreEditorial"].ToString();

            return oEditorial;


        }
        /*
        public Editorial getEditorial(int id)
        {
            var dt = DBConexion.GetDBConexion().ConsultaSQL("select * from Editorial where idEditorial=" + id);
            return mapping(dt.Rows[0]);
        }*/


        public Editorial obtenerEditorialSinParametros(int id)
        {
            String sql = string.Concat("SELECT  idEditorial,  nombreEditorial ",
                                        "FROM Editorial WHERE idEditorial=" + id + " borrado = 0 ");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }


        public Editorial obtenerEditorialConParametros(int id)
        {
            String sql = string.Concat("SELECT  idEditorial,  nombreEditorial ",
                                        "FROM Editorial WHERE idEditorial=@id AND borrado = 0 ");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public DataTable obtenerEditorialConParametros(Dictionary<string, object> parametros)
        {
            //List<Editorial> editoriales = new List<Editoriales>();
            String sql = string.Concat("SELECT  idEditorial,  nombreEditorial ",
                                        "FROM Editorial  WHERE borrado = 0 ");
            if (parametros.ContainsKey("idEditorial"))
            {
                sql += " AND idEditorial = @idEditorial ";
            }
            if (parametros.ContainsKey("nombreEditorial"))
            {
                sql += " AND nombreEditorial = @nombreEditorial";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            //foreach (DataRow row in resultado.Rows)
            //{
            //    editoriales.Add(mapping(row));
            //    return editoriales;
            //}

            return resultado;
        }



        // Operaciones CRUD

        public bool insert(Editorial oEditorial)
        {
            string sql = @"INSERT INTO Editorial (nombreEditorial) 
                VALUES('" + oEditorial.NombreEditorial +
                    "')";

            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }


        public bool update(Editorial oEditorial)
        {

            string sql = @"UPDATE Editorial " +
                "SET nombreEditorial='" + oEditorial.NombreEditorial + "' " +
                " WHERE idEditorial=" + oEditorial.IdEditorial + " AND borrado=0";

            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Editorial oEditorial)
        {

            string sql = @"UPDATE Editorial SET borrado=1 WHERE idEditorial=" + oEditorial.IdEditorial + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {

            string sql = @"UPDATE Editorial SET borrado=1 WHERE idEditorial=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }


    }
}
