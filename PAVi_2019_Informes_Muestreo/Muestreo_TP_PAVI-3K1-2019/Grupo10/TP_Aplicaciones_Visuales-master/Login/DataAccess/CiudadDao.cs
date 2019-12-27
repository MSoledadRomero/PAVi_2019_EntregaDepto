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
    class CiudadDAO: AbstractDataAccess
    {
        public IList<Ciudad> getAll()
        {
            List<Ciudad> listadoTipoDoc = new List<Ciudad>();
            var consulta = "SELECT idCiudad, nombre FROM Ciudad WHERE borrado=0"; 
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoTipoDoc.Add(mapping(row));
            }

            return listadoTipoDoc;
        }

        public Ciudad mapping(DataRow row)
        {
            Ciudad oCiudad = new Ciudad();
            oCiudad.IdCiudad = Convert.ToInt32(row["idCiudad"].ToString());
            oCiudad.Nombre = row["nombre"].ToString(); 
            return oCiudad;
        }

        public Ciudad obtenerCiudadSinParametros(int id)
        {
            String sql = string.Concat("SELECT idCiudad, nombre ",
                                        "FROM Ciudad WHERE idCiudad=" + id + " borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

        public Ciudad obtenerCiudadConParametros(int id)
        {
            String sql = string.Concat("SELECT idCiudad, nombre ",
                                        "FROM Ciudad WHERE idCiudad=@id AND borrado=0");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }
        public DataTable obtenerCiudadConParametros(Dictionary<string, object> parametros)
        {
            
            String sql = string.Concat("SELECT idCiudad, nombre ",
                                        "FROM Ciudad WHERE borrado=0");

            if (parametros.ContainsKey("idCiudad"))
            {
                sql += " AND idCiudad = @idCiudad ";
            }
            if (parametros.ContainsKey("nombre"))
            {
                sql += " AND nombre = @nombre";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            return resultado;
        }





        // Operaciones CRUD

        public bool insert(Ciudad oCiudad)
        {
            string sql = @"INSERT INTO Ciudad (nombre) 
                VALUES('" + oCiudad.Nombre +
                    "')";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool update(Ciudad oCiudad)
        {
            string sql = @"UPDATE Ciudad " +
                "SET nombre='" + oCiudad.Nombre + "'," +
                " WHERE idCiudad=" + oCiudad.IdCiudad + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Ciudad oCiudad)
        {
            string sql = @"UPDATE Ciudad SET borrado=1 WHERE idCiudad=" + oCiudad.IdCiudad + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Ciudad SET borrado=1 WHERE idCiudad=" + id+ " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        //public Barrio getProveedor(int id)
        //{
        //    var dt = DBConexion.GetDBConexion().ConsultaSQL("select * from Barrio where idBarrio=" + id);
        //    return objectMapping(dt.Rows[0]);
        //}
        //public DataTable obtenerBarrioConParametros(Dictionary<string, object> parametros)
        //{

        //    string sql = string.Concat(
        //            "SELECT  idTipoDoc AS ID,  nombre AS Nombre , ",
        //            "FROM TipoDocumento  where borrado = 0 "
        //        );
        //    if (parametros.ContainsKey("idTipoDoc"))
        //    {
        //        sql += " and idTipoDoc = @idTipoDoc ";
        //    }
        //    if (parametros.ContainsKey("nombre"))
        //    {
        //        sql += " and nombre = @nombre";
        //    }
        //    var dt = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

        //    return dt;
        //}


        //public void agregarDocumento(TipoDocumento oDocumento)
        //{
        //    string sql = @"INSERT INTO TipoDocumento (nombre) 
        //        VALUES('" + oDocumento.Nombre +
        //            "')";

        //    DBConexion.GetDBConexion().ConsultaSQL(sql);
        //}


        //public void actualizarDocumento(TipoDocumento oDocumento)
        //{

        //    string sql = @"UPDATE TipoDocumento " +
        //        "SET nombre='" + oDocumento.Nombre + "'," +
        //        " WHERE idTipoDoc=" + oDocumento.IdTipoDoc + " AND borrado=0";
        //    DBConexion.GetDBConexion().ConsultaSQL(sql);
        //}

    }
}
