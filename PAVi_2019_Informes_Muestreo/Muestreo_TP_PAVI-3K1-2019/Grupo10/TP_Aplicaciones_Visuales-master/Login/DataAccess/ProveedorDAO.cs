using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.AbstractClass;
using TP_Aplicaciones_Visuales.Entities;
using TP_Aplicaciones_Visuales.Soporte;

using System.Data;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    class ProveedorDAO : AbstractDataAccess
    {
        public IList<Proveedor> getAll()
        {
            List<Proveedor> list = new List<Proveedor>();
            String consulta =String.Concat( "SELECT P.idProveedor, P.idBarrio, P.razonSocial, P.telefono, P.mail, P.calle, P.nro "+
                                    " FROM Proveedor P WHERE P.borrado = 0");
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            
            foreach (DataRow row in resultado.Rows)
            {
                list.Add(mapping(row));
            }

            return list;
        }

        public DataTable getAllInTable()
        {
            String consulta = String.Concat("SELECT P.idProveedor AS 'Código', B.nombre AS 'Barrio' , P.razonSocial AS 'Razón Social', P.telefono AS Teléfono , P.mail AS Mail, P.calle AS Calle, P.nro AS Altura " +
                                    " FROM Proveedor P INNER JOIN Barrio B ON P.idBarrio=B.idBarrio WHERE P.borrado = 0");
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
        }

        public Proveedor mapping(DataRow row)
        {
            Proveedor oProveedor = new Proveedor();
            oProveedor.IdProveedor = Convert.ToInt32(row["idProveedor"].ToString());
            oProveedor.IdBarrio = Convert.ToInt32(row["idBarrio"].ToString());
            oProveedor.RazonSocial = row["razonSocial"].ToString();
            oProveedor.Telefono = Convert.ToInt32(row["telefono"].ToString());
            oProveedor.Mail = row["mail"].ToString();
            oProveedor.Calle = row["calle"].ToString();
            oProveedor.NroCalle = Convert.ToInt32(row["nro"].ToString());
            return oProveedor;
        }

        

        public Proveedor obtenerProveedorSinParametros(int id)
        {
            //String sql = string.Concat("SELECT P.idProveedor AS ID, P.idBarrio AS Barrio, P.razonSocial AS 'Razon Social', P.telefono AS Telefono, P.mail AS Mail, P.calle as Calle, P.nro AS 'Altura'" +
            //                            " FROM Proveedor P ",
            //                            " WHERE P.idProveedor=" + id + " AND borrado=0");
            String sql = string.Concat("SELECT P.idProveedor, P.idBarrio, B.nombre, ",
                                    "P.razonSocial, P.telefono, ",
                                    "P.mail, P.calle, P.nro ",
                                    "FROM Proveedor P inner join Barrio B on B.idBarrio = P.idBarrio WHERE idProveedor=" + id + " AND P.borrado = 0 ");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

        public Proveedor obtenerProveedorConParametros(int id)
        {
            String sql = string.Concat("SELECT P.idProveedor, P.idBarrio,B.nombre, ",
                                    "P.razonSocial, P.telefono,",
                                    "P.mail, P.calle, P.nro",
                                    "FROM Proveedor P inner join Barrio B on B.idBarrio = P.idBarrio WHERE idProveedor=@id AND P.borrado = 0 ");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public DataTable obtenerProveedoresConParametros(Dictionary<string, object> parametros)
        {

            //string sql = string.Concat(
            //        "SELECT P.idProveedor AS ID, B.nombre AS Barrio , ",
            //        "P.razonSocial AS 'Razon Social', P.telefono AS Telefono,",
            //        "P.mail AS Mail, P.calle as Calle, P.nro as 'Altura'",
            //        "FROM Proveedor P inner join Barrio B on B.idBarrio = P.idBarrio where P.borrado = 0 "
            //    );
            String sql = string.Concat("SELECT P.idProveedor, B.nombre, ",
                    "P.razonSocial, P.telefono,",
                    "P.mail, P.calle, P.nro ",
                    "FROM Proveedor P inner join Barrio B on B.idBarrio = P.idBarrio WHERE P.borrado = 0 ");

            if (parametros.ContainsKey("idBarrio"))
            {
                sql += " AND P.idBarrio = @idBarrio ";
            }
            if (parametros.ContainsKey("idProveedor"))
            {
                sql += " AND P.idProveedor = @idProveedor ";
            }
            if (parametros.ContainsKey("razonSocial"))
            {
                sql += " AND P.razonSocial = @razonSocial";
            }
            if (parametros.ContainsKey("telefono"))
            {
                sql += " AND P.telefono = @telefono";
            }
            if (parametros.ContainsKey("mail"))
            {
                sql += " AND P.mail = @mail";
            }
            if (parametros.ContainsKey("calle"))
            {
                sql += " AND P.calle = @calle";
            }
            if (parametros.ContainsKey("nro"))
            {
                sql += " AND P.nro = @nro";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

            return resultado;
        }





        // Operaciones CRUD

        public bool insert(Proveedor oProvedor)
        {
            string sql = @"INSERT INTO Proveedor (idBarrio,razonSocial,telefono,mail,calle,nro) 
                VALUES(" + oProvedor.IdBarrio +
                ",'" + oProvedor.RazonSocial +
                "'," + oProvedor.Telefono +
                ",'" + oProvedor.Mail +
                "','" + oProvedor.Calle +
                "'," + oProvedor.NroCalle + ")";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool update(Proveedor oProveedor)
        {
            string sql = @"UPDATE Proveedor " +
                "SET idBarrio =" + oProveedor.IdBarrio + "," +
                "razonSocial='" + oProveedor.RazonSocial + "'," +
                "telefono=" + oProveedor.Telefono + "," +
                "mail='" + oProveedor.Mail + "'," +
                "calle='" + oProveedor.Calle + "'," +
                "nro=" + oProveedor.NroCalle +
                " WHERE idProveedor=" + oProveedor.IdProveedor + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Proveedor oProveedor)
        {
            string sql = @"UPDATE Proveedor SET borrado=1 WHERE idProveedor=" + oProveedor.IdProveedor + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Proveedor SET borrado=1 WHERE idProveedor=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        /*public IList<Proveedor> GetByFiltersSinParametros(String condiciones)
        {

            List<Proveedor> lst = new List<Proveedor>();
            String strSql = string.Concat(" SELECT idProveedor, ",
                                          "        razonSocial, ",
                                          "        telefono, ",
                                          "        mail, ",
                                          "        calle, ",
                                          "        nro, ",
                                          "        b.idBarrio, ",
                                          "        b.nombre as Barrio ",
                                          "   FROM Proveedor p",
                                          "  INNER JOIN Barrio b ON p.idBarrio = b.idBarrio ");
            strSql += condiciones;
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(mapping(row));

            return lst;
        }*/
    }
}
