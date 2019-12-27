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
    class TipoDocumentoDAO : AbstractDataAccess
    {
        public IList<TipoDocumento> getAll()
        {
            List<TipoDocumento> listadoTipoDoc = new List<TipoDocumento>();
            var consulta = "SELECT idTipoDoc, nombre FROM TipoDocumento WHERE borrado=0"; 
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoTipoDoc.Add(mapping(row));
            }

            return listadoTipoDoc;
        }

        public DataTable getAllInTable()
        {
            var consulta = "SELECT idTipoDoc AS 'Código Tipo Doc.', nombre AS 'Tipo Doc.' FROM TipoDocumento WHERE borrado=0";
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
        }

        public TipoDocumento mapping(DataRow row)
        {
            TipoDocumento oTipoDoc = new TipoDocumento();
            oTipoDoc.IdTipoDoc = Convert.ToInt32(row["idTipoDoc"].ToString());
            oTipoDoc.Nombre = row["nombre"].ToString(); //Todo: AGREGAR A TODAS LAS ENTIDADES EL ATRIBUTO DE BORRADO
            return oTipoDoc;
        }

        public TipoDocumento obtenerTipoDocumentoSinParametros(int id)
        {
            String sql = string.Concat("SELECT idTipoDoc, nombre ",
                                        "FROM TipoDocumento WHERE idTipoDoc=" + id + " borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

       


        public TipoDocumento obtenerTipoDocumentoConParametros(int id)
        {
            String sql = string.Concat("SELECT idTipoDoc, nombre ",
                                        "FROM TipoDocumento WHERE idTipoDoc=@id AND borrado=0");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public TipoDocumento obtenerTipoDocumentoConParametros(string nom)
        {
            String sql = string.Concat("SELECT idTipoDoc, nombre ",
                                        "FROM TipoDocumento WHERE nombre=@nombreTD AND borrado=0");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombreTD", nom);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public DataTable obtenerTipoDocumentoConParametros(Dictionary<string, object> parametros)
        {
         
            String sql = string.Concat("SELECT idTipoDoc, nombre ",
                                        "FROM TipoDocumento WHERE borrado=0");

            if (parametros.ContainsKey("idTipoDoc"))
            {
                sql += " AND idTipoDoc = @idTipoDoc ";
            }
            if (parametros.ContainsKey("nombre"))
            {
                sql += " AND nombre = @nombre";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            return resultado;
        }

        /*
        public TipoDocumento getTipoDocumento(int id)
        {
            var dt = DBConexion.GetDBConexion().ConsultaSQL("select * from TipoDocumento where idTipoDoc=" + id);
            return Mapping(dt.Rows[0]);
        }
        */

        // Operaciones CRUD

        public bool insert(TipoDocumento oTipoDocumento)
        {
            string sql = @"INSERT INTO TipoDocumento (nombre) 
                VALUES('" + oTipoDocumento.Nombre +
                    "')";

            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }


        public bool update(TipoDocumento oTipoDocumento)
        {
            string sql = @"UPDATE TipoDocumento " +
                " SET nombre='" + oTipoDocumento.Nombre + "' " +
                " WHERE idTipoDoc=" + oTipoDocumento.IdTipoDoc + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(TipoDocumento oTipoDocumento)
        {
            string sql = @"UPDATE TipoDocumento SET borrado=1 WHERE idTipoDoc=" + oTipoDocumento.IdTipoDoc + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE TipoDocumento SET borrado=1 WHERE idTipoDoc=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }


    }
}
