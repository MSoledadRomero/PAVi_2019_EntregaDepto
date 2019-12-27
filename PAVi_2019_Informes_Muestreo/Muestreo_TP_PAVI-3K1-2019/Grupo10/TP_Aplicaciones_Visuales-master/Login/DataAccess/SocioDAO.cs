using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.Entities;
using System.Data;
using TP_Aplicaciones_Visuales.AbstractClass;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    class SocioDAO : AbstractDataAccess
    {
        public IList<Socio> getAll()
        {
            List<Socio> listadoSocio = new List<Socio>();
            var consulta = "SELECT idSocio, idTipoDoc, idBarrio, numeroDocumento, nombre, apellido, mail, telefono, calle, nro FROM Socio WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoSocio.Add(mapping(row));
            }

            return listadoSocio;
        }

        public DataTable getAllInTable()
        {
            String consulta = string.Concat("SELECT S.idSocio AS 'Código', T.nombre AS 'Tipo Doc.' ," +
                                            " B.nombre AS 'Barrio', S.numeroDocumento AS 'Numero Documento', S.nombre AS 'Nombre'," +
                                            " S.apellido AS 'Apellido', S.mail AS 'Mail', S.telefono AS 'Teléfono'," +
                                            " S.calle AS 'Calle', S.nro AS 'Altura' ",
                                             " FROM Socio S ",
                                             " JOIN TipoDocumento T ON S.idTipoDoc=T.idTipoDoc ",
                                             " JOIN Barrio B ON S.idBarrio =B.idBarrio ",
                                             " WHERE S.borrado=0");
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
        }


        public Socio mapping(DataRow row)
        {
            Socio oSocio = new Socio();
            oSocio.IdSocio = Convert.ToInt32(row["idSocio"].ToString()); //Porque lo convierte primero a to string y despues a int??
            oSocio.IdTipoDoc = Convert.ToInt32(row["idTipoDoc"].ToString());
            oSocio.IdBarrio = Convert.ToInt32(row["idBarrio"].ToString());
            oSocio.NumeroDocumento = Convert.ToInt32(row["numeroDocumento"].ToString());
            oSocio.Nombre = row["nombre"].ToString();
            oSocio.Apellido = row["apellido"].ToString();
            oSocio.Mail = row["mail"].ToString();
            oSocio.Telefono = Convert.ToInt32(row["telefono"].ToString());
            oSocio.Calle = row["calle"].ToString();
            oSocio.Nro = Convert.ToInt32(row["nro"].ToString());
            return oSocio;
        }




        //Aca estaba el metodo de obtener ultimo



        //Este metodo permite encontrar un socio determinado por su id (el id es unico)
        public Socio obtenerSocioSinParametros(int id)
        {
            String sql = string.Concat("SELECT S.idSocio, S.idTipoDoc, S.idBarrio, S.numeroDocumento, S.nombre, S.apellido, S.mail, S.telefono, S.calle, S.nro ",
                                    " FROM Socio S ",
                                    " JOIN TipoDocumento T ON S.idTipoDoc=T.idTipoDoc ",
                                    " JOIN Barrio B ON S.idBarrio =B.idBarrio ",
                                    " WHERE S.idSocio=" + id + " AND S.borrado=0");

            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
           
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
                
            }
            return null;

        }




        //Este metodo devuelve una lista de socios que coincide el dni con los parametros enviados, esto es por si necesito insertar un socio
        //no tengo numero de socio para poder comparar, entonces comparo por dni, si hay un socio con el mismo dni quiere decir que ya esta registrado
        //Devuelve varios porque el dni puede no ser unico

        public IList<Socio> obtenerSocioSinParametros(int idTipoD, int documento)
        {
            String sql = string.Concat("SELECT S.idSocio, S.idTipoDoc, S.idBarrio, S.numeroDocumento, S.nombre, S.apellido, S.mail, S.telefono, S.calle, S.nro ",
                                    " FROM Socio S ",
                                    " JOIN TipoDocumento T ON S.idTipoDoc=T.idTipoDoc ",
                                    " JOIN Barrio B ON S.idBarrio =B.idBarrio ",                                   
                                    " WHERE S.idTipoDoc=" + idTipoD + " AND S.numeroDocumento="+ documento +" AND S.borrado=0");

            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            List<Socio> sociosEncontrados = new List<Socio>();
            sociosEncontrados.Add(mapping(resultado.Rows[0]));
            
            if (resultado.Rows.Count > 0)
            {
                foreach(DataRow row in resultado.Rows)
                {
                    sociosEncontrados.Add(mapping(row));
                }
                
                return sociosEncontrados;

            }
            return null;

        }

        //Este metodo permite encontrar un socio determinado por su id (el id es unico)
        public IList<Socio> obtenerSocioConParametros(int id)
        {
            String sql = string.Concat("SELECT S.idSocio, S.idTipoDoc, S.idBarrio, S.numeroDocumento, S.nombre, S.apellido, S.mail, S.telefono, S.calle, S.nro ",
                                    " FROM Socio S ",
                                    " JOIN TipoDocumento T ON S.idTipoDoc=T.idTipoDoc ",
                                    " JOIN Barrio B ON S.idBarrio =B.idBarrio ",
                                    " WHERE S.idSocio = @id AND S.borrado=0");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

            List<Socio> socioEncontrado = new List<Socio>();

            if (resultado.Rows.Count > 0)
            {
                socioEncontrado.Add(mapping(resultado.Rows[0]));
                return socioEncontrado;

            }
            return null;

        }


        //Este metodo devuelve una lista de socios que coincide el dni con los parametros enviados, esto es por si necesito insertar un socio
        //no tengo numero de socio para poder comparar, entonces comparo por dni, si hay un socio con el mismo dni quiere decir que ya esta registrado
        //Devuelve varios porque el dni puede no ser unico
        public IList<Socio> obtenerSocioConParametros(int idTipoD,int documento)
        {
            String sql = string.Concat("SELECT S.idSocio, S.idTipoDoc, S.idBarrio, S.numeroDocumento, S.nombre, S.apellido, S.mail, S.telefono, S.calle, S.nro ",
                                    " FROM Socio S ",
                                    " JOIN TipoDocumento T ON S.idTipoDoc=T.idTipoDoc ",
                                    " JOIN Barrio B ON S.idBarrio =B.idBarrio ",
                                    " WHERE S.idTipoDoc = @idTipo AND S.numeroDocumento=@doc AND S.borrado=0");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idTipo", idTipoD);
            parametros.Add("doc", documento);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

            List<Socio> sociosEncontrados = new List<Socio>();

            if (resultado.Rows.Count > 0)
            {
               foreach(DataRow row in resultado.Rows)
               {
                    sociosEncontrados.Add(mapping(row));
               }
               return sociosEncontrados;

            }
            return null;

        }


        public DataTable obtenerSocioConParametros(Dictionary<string, object> parametros)
        {
            String sql = string.Concat("SELECT S.idSocio, S.idTipoDoc, T.nombre, S.idBarrio, B.nombre , S.numeroDocumento ,",
                                "S.nombre, S.apellido , S.mail , S.telefono , S.calle , S.nro ",
                                "FROM Socio S ",
                                "JOIN TipoDocumento T ON S.idTipoDoc = T.idTipoDoc ",
                                "JOIN Barrio B ON S.idBarrio = B.idBarrio ",
                                "WHERE S.borrado = 0");
            
            
            if (parametros.ContainsKey("idSocio"))
                sql += " AND S.idSocio = @idSocio "; 


            if (parametros.ContainsKey("tipoD"))
                sql += " AND  S.idTipoDoc= @tipoD ";

            if (parametros.ContainsKey("barrio"))
                sql += " AND  S.idBarrio=@barrio ";
            
            if (parametros.ContainsKey("numeroDoc"))
                sql += " AND  S.numeroDocumento=@numeroDoc ";

            if (parametros.ContainsKey("nomb"))
                sql += " AND  S.nombre=@nomb ";

            if (parametros.ContainsKey("ape"))
                sql += " AND  S.apellido=@ape";

            if (parametros.ContainsKey("email"))
                sql += " AND  S.mail=@email ";

            if (parametros.ContainsKey("tel"))
                sql += " AND  S.telefono=@tel ";

            if (parametros.ContainsKey("nombreCalle"))
                sql += " AND  S.calle=@nombreCalle ";

            if (parametros.ContainsKey("nroCalle"))
                sql += " AND  S.nro=@nroCalle ";


            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            //List<Socio> sociosEncontrados = new List<Socio>();

            //if (resultado.Rows.Count > 0)
            //{
            //    foreach (DataRow row in resultado.Rows)
            //    {
            //        sociosEncontrados.Add(Mapping(row));
            //    }
            //    return sociosEncontrados;

            //}
            return resultado;     
        }

        // Operaciones CRUD


        public bool insert(Socio oSocio)
        {            
            string sql = @"INSERT INTO Socio (idTipoDoc,idBarrio,numeroDocumento,nombre,apellido,mail,telefono,calle,nro)  VALUES (" + oSocio.IdTipoDoc + ", " + oSocio.IdBarrio + ", " + oSocio.NumeroDocumento + ", '" + oSocio.Nombre + "', '" + oSocio.Apellido + "', '" + oSocio.Mail + "', " + oSocio.Telefono + ", '" + oSocio.Calle + "', " + oSocio.Nro + ")";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);

        }

        public bool update(Socio oSocio)
        {
            String sql = string.Concat("UPDATE Socio SET idTipoDoc =" + oSocio.IdTipoDoc + ", " ,
                                       " idBarrio=" + oSocio.IdBarrio + ", ",                                   
                                       " numeroDocumento="+oSocio.NumeroDocumento+", ",
                                       " nombre='"+oSocio.Nombre+"', ",
                                       " apellido='"+oSocio.Apellido+"', ",
                                       " mail='"+oSocio.Mail+"', ",
                                       " telefono="+oSocio.Telefono+", ",
                                       " calle='"+oSocio.Calle+"', ",
                                       " nro="+oSocio.Nro+" ",
                                       " WHERE idSocio="+oSocio.IdSocio+" AND borrado=0");
                        
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);

        }

        public bool logicalDelete(Socio oSocio)
        {
            string sql= @"UPDATE Socio SET borrado=1 WHERE idSocio = " + oSocio.IdSocio + " AND borrado=0";
            //TransactionSql devuelve int, de la cantidad de filas afectadas, si es =1 quiere decir que se ejecuto correctamente el UPDATE
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql))==1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Socio SET borrado=1 WHERE idSocio = " + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);

        }

    }
   

    
}
