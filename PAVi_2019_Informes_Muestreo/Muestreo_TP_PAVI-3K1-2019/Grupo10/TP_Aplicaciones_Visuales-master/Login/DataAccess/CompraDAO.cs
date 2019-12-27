using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.Entities;
using TP_Aplicaciones_Visuales.AbstractClass;
using System.Data;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    class CompraDAO : AbstractDataAccess
    {
        public IList<Compra> getAll()
        {
            List<Compra> listadoCompra = new List<Compra>();


            var consulta = "SELECT  C.fechaCompra, C.idProveedor, C.idCompra , P.razonSocial , P.calle, P.idBarrio, P.mail, P.nro, P.telefono FROM Compra C Join Proveedor P on P.idProveedor = C.idProveedor  WHERE C.borrado=0 ";


            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoCompra.Add(mapping(row));
            }
            return listadoCompra;

        }
        public void update(Compra oCompra)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            int afectadas = 0;
            string sql = "";

            //Agrego los parametros al diccionario
            parametros.Add("idProveedor", oCompra.OProveedor.IdProveedor);
            parametros.Add("idCompra", oCompra.IdCompra);

            //Inicio la trasaccion
            DBConexion.GetDBConexion().beginTransaction();
            try
            {
                sql = "UPDATE Compra SET idProveedor = @idProveedor where idCompra = @idCompra";
                afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DBConexion.GetDBConexion().CloseConnection();
            }

        }

        public Compra mapping(DataRow row)
        {
            Compra oCompra = new Compra();
            oCompra.IdCompra = Convert.ToInt32(row["idCompra"].ToString());
            oCompra.FechaDeCompra = Convert.ToDateTime(row["fechaCompra"].ToString());
            
            oCompra.OProveedor = new Proveedor();
            oCompra.OProveedor.IdProveedor = Convert.ToInt32(row["idProveedor"].ToString());
            oCompra.OProveedor.Mail = row["mail"].ToString();
            oCompra.OProveedor.NroCalle = Convert.ToInt32(row["nro"].ToString());
            oCompra.OProveedor.RazonSocial = row["razonSocial"].ToString();


            oCompra.OProveedor.Telefono = Convert.ToInt32(row["telefono"].ToString());
            oCompra.OProveedor.IdBarrio = Convert.ToInt32(row["idBarrio"].ToString());
            oCompra.OProveedor.Calle = row["calle"].ToString();


            return oCompra;
        }
        public DataTable getAllInTable()
        {
            var consulta =  " SELECT C.idCompra AS 'Código', C.fechaCompra AS 'Fecha de Compra', P.razonSocial AS 'Proveedor'" + 
                            " FROM Compra C " +
                            " INNER JOIN Proveedor P ON C.idProveedor=P.idProveedor " +
                            " WHERE C.borrado=0 ";
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
        }

  

        public Compra obtenerCompraSinParametros(int id)
        {
            String sql = string.Concat(" SELECT  C.fechaCompra, C.idProveedor, C.idCompra , P.razonSocial , P.calle, P.idBarrio, P.mail, P.nro, P.telefono FROM Compra C Join Proveedor P on P.idProveedor = C.idProveedor  WHERE C.borrado=0  and C.idCompra = " + id+" AND C.borrado=0");

            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }




        public IList<Compra> obtenerCompraConParametros(Dictionary<string, object> parametros)
        {

            List<Compra> listadoCompra = new List<Compra>();

            String sql = " SELECT  C.fechaCompra, C.idProveedor, C.idCompra , P.razonSocial , P.calle, P.idBarrio, P.mail, P.nro, P.telefono FROM Compra C Join Proveedor P on P.idProveedor = C.idProveedor  WHERE C.borrado=0   ";


            if (parametros.ContainsKey("idCompra"))
            {

                sql += " AND C.idCompra = @idCompra ";
            }
            if (parametros.ContainsKey("fechaCompra"))
            {
                sql += " AND C.fechaCompra = @fechaCompra";
            }
            if (parametros.ContainsKey("idProveedor"))
            {
                sql += " AND C.idProveedor = @idProveedor";
            }

            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql,parametros);
            foreach (DataRow row in resultado.Rows)
            {
                listadoCompra.Add(mapping(row));
            }

            return listadoCompra;
        }


   



        public bool Lastinsert(Compra oCompra)
        {
            //Defino lo que necesito
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            int afectadas = 0;           
            string sql = "";

            //Agrego los parametros al diccionario
            parametros.Add("idProveedor", oCompra.OProveedor.IdProveedor);

            //Inicio la trasaccion
            DBConexion.GetDBConexion().beginTransaction();
            try
            {
                //Inserto la compra       Con la fecha actual---------> CONVERT(datetime ,GetDate(), 111)
                sql = "INSERT INTO Compra (fechaCompra,idProveedor) VALUES (GetDate(),@idProveedor)";
                afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);        
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DBConexion.GetDBConexion().CloseConnection();
            }
            return (afectadas != 0);
        }



        //Da de baja la compra, sus detalle, los libros y ejemplares
        public bool logicalDelete(Compra oCompra)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();



            String sql =  "";


            DBConexion.GetDBConexion().beginTransaction();
            int afectadas = 0;
            try
            {
                //Eliminamos la COMPRA
                parametros.Add("idCompra", oCompra.IdCompra);
                sql = string.Concat("UPDATE Compra SET borrado=1 WHERE idCompra=@idCompra AND borrado=0");
                afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                parametros.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DBConexion.GetDBConexion().CloseConnection();
            }
            return (afectadas != 0);
        }

    }
}
