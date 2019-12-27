using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales;
using TP_Aplicaciones_Visuales.Entities;
using System.Data;
using TP_Aplicaciones_Visuales.AbstractClass;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    class PerfilDAO : AbstractDataAccess
    {
        public IList<Perfil> getAll()
        {
            List<Perfil> listadoBugs = new List<Perfil>();

            var strSql = "SELECT idPerfil, nombre FROM Perfil WHERE borrado=0";

            var resultadoConsulta = DBConexion.GetDBConexion().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(mapping(row));
            }

            return listadoBugs;
        }

        private Perfil mapping(DataRow row)
        {
            Perfil oPerfil = new Perfil();
            oPerfil.IdPerfil = Convert.ToInt32(row["idPerfil"].ToString());
            oPerfil.Nombre = row["nombre"].ToString();
            return oPerfil;
        }

        public Perfil obtenerPerfilSinParametros(int id)
        {
            String sql = string.Concat("SELECT idPerfil, nombre ",
                                        "FROM Perfil WHERE idPerfil=" + id + " borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

        public Perfil obtenerPerfilConParametros(int id)
        {
            String sql = string.Concat("SELECT idPerfil, nombre ",
                                        "FROM Perfil WHERE idPerfil=@id AND borrado=0");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public Perfil obtenerPerfilConParametros(string nom)
        {
            String sql = string.Concat("SELECT idPerfil, nombre ",
                                        "FROM Perfil WHERE nombre=@nombrePerfil AND borrado=0");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombrePerfil", nom);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public DataTable obtenerPerfilConParametros(Dictionary<string, object> parametros)
        {
          
            String sql = string.Concat("SELECT idPerfil, nombre ",
                                        "FROM Perfil WHERE borrado=0");

            if (parametros.ContainsKey("idPerfil"))
            {
                sql += " AND idPerfil = @idPerfil ";
            }
            if (parametros.ContainsKey("nombre"))
            {
                sql += " AND nombre = @nombre";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            return resultado;
        }



        public bool insert(Perfil oPerfil)
        {
            string sql = @"INSERT INTO Perfil (nombre) VALUES ('" + oPerfil.Nombre + "')";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool update(Perfil oPerfil)
        {
            string sql = @"UPDATE Perfil SET nombre='" + oPerfil.Nombre + "' " +
                        "WHERE idPerfil=" + oPerfil.IdPerfil + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Perfil oPerfil)
        {
            string sql = @"UPDATE Perfil SET borrado=1 WHERE idPerfil=" + oPerfil.IdPerfil + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Perfil SET borrado=1 WHERE idPerfil=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

    }
}

