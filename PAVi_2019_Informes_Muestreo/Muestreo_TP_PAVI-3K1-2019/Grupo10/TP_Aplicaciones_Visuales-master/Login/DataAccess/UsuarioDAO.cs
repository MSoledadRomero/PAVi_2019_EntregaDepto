using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_Aplicaciones_Visuales.Entities;
using System.Data.SqlClient;
using TP_Aplicaciones_Visuales.AbstractClass;


namespace TP_Aplicaciones_Visuales.DataAccess
{
    class UsuarioDAO : AbstractDataAccess
    {
        public IList<Usuario> getAll()
        {
            List<Usuario> listadoUsuario = new List<Usuario>();
            // var consulta = "SELECT idUsuario, nombre, contraseña FROM Usuario WHERE borrado=0";
            var consulta = "SELECT idUsuario, usuario, contraseña, estado, p.idPerfil, p.nombre FROM Usuario u INNER JOIN perfil p ON u.idPerfil = p.idPerfil WHERE u.borrado = 0 ";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoUsuario.Add(mapping(row));
            }

            return listadoUsuario;
        }

        public Usuario mapping(DataRow row)
        {   /*
            Usuario oUsuario= new Usuario();
            oUsuario.IdUsuario = Convert.ToInt32(row["idUsuario"].ToString()); 
            oUsuario.Contraseña =row["usuario"].ToString();
            oUsuario.NombreUsuario = row["contraseña"].ToString();
            return oUsuario;*/
            Usuario oUsuario = new Usuario();
            oUsuario.IdUsuario = Convert.ToInt32(row["idUsuario"].ToString());
            oUsuario.Contraseña = row["contraseña"].ToString();
            oUsuario.NombreUsuario = row["usuario"].ToString();
            oUsuario.Estado = row["estado"].ToString();
            oUsuario.Perfil = new Perfil();
            oUsuario.Perfil.IdPerfil = Convert.ToInt32(row["idPerfil"].ToString());
            oUsuario.Perfil.Nombre = row["nombre"].ToString();
            return oUsuario;
        }

        /*public Usuario GetUserSinParametros(string nombreUsuario)
        {
            String strSql = string.Concat(" SELECT idUsuario, ",
                                          "        usuario, ",
                                          "        estado, ",
                                          "        contraseña, ",
                                          "        p.idPerfil, ",
                                          "        p.nombre as perfil ",
                                          "   FROM Usuario u",
                                          "  INNER JOIN perfil p ON u.idPerfil= p.idPerfil ",
                                          "  WHERE u.estado = 'S' ");

            strSql += " AND usuario=" + "'" + nombreUsuario + "'";

            var resultado = DBConexion.GetDBConexion().ConsultaSQL(strSql);
           
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }

            return null;
        }
        
         
            
            public Usuario obtenerUsuarioPorNombre(string nUsuario)
        {
            Usuario usuarioBuscado = new Usuario();
            try
            {
                String consultaSql = string.Concat(" SELECT * ",
                                                   "   FROM Usuario ",
                                                   "  WHERE usuario =  '", nUsuario, "' AND borrado=0");


                DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(consultaSql);
                if(resultado.Rows.Count>0)
                {
                    usuarioBuscado=Mapping(resultado.Rows[0]);
                }
                else
                {
                    return null; //TOdo: ver si esta bien
                }
               
            }
            catch (SqlException ex)
            {
                //Mostramos un mensaje de error indicando que hubo un error en la base de datos.
                throw ex;
            }
            return usuarioBuscado;
        }
             
             */

        public Usuario obtenerUsuarioSinParametros(int id)
        {
            String sql = string.Concat("SELECT idUsuario, usuario, contraseña, estado, p.idPerfil, p.nombre  ",
                                        " FROM Usuario u INNER JOIN perfil p ON u.idPerfil = p.idPerfil WHERE u.idUsuario =" + id + " AND u.borrado = 0 ");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

        public Usuario obtenerUsuarioConParametros(int id)
        {
            String sql = string.Concat("SELECT idUsuario, usuario, contraseña, estado, p.idPerfil, p.nombre FROM Usuario u INNER JOIN perfil p ON u.idPerfil = p.idPerfil WHERE u.idUsuario=@id AND u.borrado = 0 ");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public Usuario obtenerUsuarioConParametros(string nom)
        {
            String sql = string.Concat("SELECT idUsuario, usuario, contraseña, estado, p.idPerfil, p.nombre FROM Usuario u INNER JOIN perfil p ON u.idPerfil = p.idPerfil WHERE u.usuario=@nombreUsuario AND u.borrado = 0 ");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombreUsuario", nom);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public DataTable obtenerUsuarioConParametros(Dictionary<string, object> parametros)
        {

            String sql = string.Concat("SELECT idUsuario, usuario, contraseña, estado, p.idPerfil, p.nombre ",
                                        "FROM Usuario u INNER JOIN perfil p ON u.idPerfil = p.idPerfil WHERE u.borrado = 0 ");

            if (parametros.ContainsKey("idUsuario"))
            {
                sql += " AND idUsuario = @idUsuario ";
            }
            if (parametros.ContainsKey("usuario"))
            {
                sql += " AND usuario = @usuario";
            }
            if (parametros.ContainsKey("idPerfil"))
            {
                sql += " AND idPerfil = @idPerfil";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

            return resultado;
        }

        //internal bool Create(Usuario oUsuario)
        //{
        //    string str_sql = "INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado)" +
        //                       " VALUES (" +
        //                       "'" + oUsuario.NombreUsuario + "'" + "," +
        //                       "'" + oUsuario.Contraseña + "'" + "," +
        //                       "'" + oUsuario.Estado + "'" + "," +
        //                       oUsuario.Perfil.IdPerfil + ",0)";


        //    return (DBConexion.GetDBConexion().ExecuteSQL(str_sql) == 1);
        //}
        //internal bool Update(Usuario oUsuario)
        //{
        //    string str_sql = "UPDATE Usuario " +
        //                        "SET usuario =" + "'" + oUsuario.NombreUsuario + "'" + "," +
        //                        " contraseña =" + "'" + oUsuario.Contraseña + "'" + "," +
        //                        " estado =" + "'" + oUsuario.Estado + "'" + "," +
        //                        " idPerfil =" + oUsuario.Perfil.IdPerfil +
        //                        " WHERE idUsuario =" + oUsuario.IdUsuario;

        //    return (DBConexion.GetDBConexion().ExecuteSQL(str_sql) == 1);
        //}
        //internal bool delete(Usuario oUsuario)
        //{
        //    string str_sql = "UPDATE Usuario " +
        //                        "SET usuario =" + "'" + oUsuario.NombreUsuario + "'" + "," +
        //                        " contraseña =" + "'" + oUsuario.Contraseña + "'" + "," +
        //                        " estado =" + "'" + oUsuario.Estado + "'" + "," +
        //                        " idPerfil =" + "'" + oUsuario.Perfil.IdPerfil + "'" + "," +
        //                        " borrado = '1' " +
        //                        " WHERE idUsuario =" + oUsuario.IdUsuario;

        //    return (DBConexion.GetDBConexion().ExecuteSQL(str_sql) == 1);
        //}

        //public Usuario obtenerUsuarioPorNombre(string nUsuario)
        //{
        //    Usuario usuarioBuscado = new Usuario();
        //    try
        //    {
        //        String consultaSql = string.Concat("SELECT idUsuario, usuario, contraseña, estado, p.idPerfil, p.nombre",
        //                                            " FROM Usuario u INNER JOIN perfil p ON u.idPerfil = p.idPerfil WHERE usuario='"+nUsuario+"' AND u.borrado = 0 "); 


        //        DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(consultaSql);
        //        if(resultado.Rows.Count>0)
        //        {
        //            usuarioBuscado=mapping(resultado.Rows[0]);
        //        }
        //        else
        //        {
        //            return null; //TOdo: ver si esta bien
        //        }

        //    }
        //    catch (SqlException ex)
        //    {
        //        //Mostramos un mensaje de error indicando que hubo un error en la base de datos.
        //        throw ex;
        //    }
        //    return usuarioBuscado;
        //}
        //public IList<Usuario> GetByFiltersSinParametros(String condiciones)
        //{

        //    List<Usuario> lst = new List<Usuario>();
        //    String strSql = string.Concat(" SELECT idUsuario, ",
        //                                      "        usuario, ",
        //                                      "        contraseña, ",
        //                                      "        estado, ",
        //                                      "        p.idPerfil, ",
        //                                      "        p.nombre as perfil ",
        //                                      "   FROM Usuario u",
        //                                      "  INNER JOIN perfil p ON u.idPerfil = p.idPerfil ",
        //                                      "  WHERE u.borrado = '0' AND u.estado = 'S'");
        //    strSql += condiciones;
        //    var resultado = DBConexion.GetDBConexion().ConsultaSQL(strSql);


        //    foreach (DataRow row in resultado.Rows)
        //        lst.Add(mapping(row));

        //    return lst;
        //}



        // Operaciones CRUD

        public bool insert(Usuario oUsuario)
        {
            string sql = "INSERT INTO Usuario (usuario, contraseña, estado, idPerfil, borrado)" +
                                " VALUES (" +
                                "'" + oUsuario.NombreUsuario + "'" + "," +
                                "'" + oUsuario.Contraseña + "'" + "," +
                                "'" + oUsuario.Estado + "'" + "," +
                                oUsuario.Perfil.IdPerfil + ",0)";

            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool update(Usuario oUsuario)
        {
            string sql = "UPDATE Usuario " +
                                "SET usuario =" + "'" + oUsuario.NombreUsuario + "'" + "," +
                                " contraseña =" + "'" + oUsuario.Contraseña + "'" + "," +
                                " estado =" + "'" + oUsuario.Estado + "'" + "," +
                                " idPerfil =" + oUsuario.Perfil.IdPerfil +
                                " WHERE idUsuario =" + oUsuario.IdUsuario;
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Usuario oUsuario)
        {
            string sql = @"UPDATE Usuario SET borrado=1 WHERE idUsuario=" + oUsuario.IdUsuario + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Usuario SET borrado=1 WHERE idUsuario=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

    }
}
