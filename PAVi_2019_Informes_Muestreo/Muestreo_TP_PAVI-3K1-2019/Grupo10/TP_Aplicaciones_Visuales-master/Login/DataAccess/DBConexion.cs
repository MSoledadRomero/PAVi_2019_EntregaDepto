using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TP_Aplicaciones_Visuales
{
    class DBConexion
    {
        private static DBConexion instance;
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlTransaction t;
        private string string_conexion;
        private ResultadoTransaccion resultadoTransaccion;
        private TipoConexion tipoConexion;
        

        private DBConexion()
        {
            string_conexion = "Data Source=DESKTOP-BF1D9SV\\SQLEXPRESS;Initial Catalog=biblioteca1;Integrated Security=True";
            //"Data Source=DESKTOP-IQCE3H1\\SQLEXPRESS;Initial Catalog=biblioteca2;Integrated Security=True";
            //"Data Source=MONEF;Initial Catalog=biblioteca;Integrated Security=True";
            //"Data Source=MONEF;Initial Catalog=biblioteca;Integrated Security=True";
            //"Data Source=DESKTOP-IQCE3H1\\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True";
            //"Data Source=maquis;Initial Catalog=biblioteca_v1;User ID=avisuales1;Password=avisuales1";

            cnn = new SqlConnection();
            cmd = new SqlCommand();
            resultadoTransaccion = ResultadoTransaccion.exito;
            tipoConexion = TipoConexion.simple;
                     

        }

        enum ResultadoTransaccion
        {
            exito, fracaso
        }

        enum TipoConexion
        {
            simple, transaccion
        }

        public static DBConexion GetDBConexion()
        {
            if (instance == null)
                instance = new DBConexion();
            return instance;
        }

         /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un valor entero con el número de filas afectadas por la sentencia ejecutada
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        ///              
        

        public int ExecuteSQL(string strSql)
        {
            int afectadas = 0;
            SqlTransaction t = null;
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //comienzo de transaccion...
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                
                afectadas = cmd.ExecuteNonQuery();
                //Commit de transacción...
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                Console.WriteLine(string.Concat("Error en ejecutarSQL: ", ex.Message));
            }
            finally
            {
                this.CloseConnection();
            }

            return afectadas;
        }




        /// Resumen:
        ///     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        /// Devuelve:
        ///      un objeto de tipo DataTable con el resultado de la consulta
        /// Excepciones:
        ///      System.Data.SqlClient.SqlException:
        ///          El error de conexión se produce:
        ///              a) durante la apertura de la conexión
        ///              b) durante la ejecución del comando.
        public DataTable ConsultaSQL(string strSql)
        {
           
            DataTable tabla = new DataTable();
            
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(string.Concat("Error en la consulta: ", ex.Message));
                throw ex;

            }
            finally
            {
                this.CloseConnection();
            }
        }




        
        public DataTable storeProcedureSql(string nombreProcedimiento)
        {
            
            DataTable tabla = new DataTable();
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreProcedimiento;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(string.Concat("Error en la consulta del procedimiento almacenado" , ex.Message));
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }




        public DataTable ConsultaSQLConParametros(string sqlConsulta,Dictionary<string,object> parametros)
        {            
            DataTable tabla=new DataTable();
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlConsulta;
                foreach(var p in parametros)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }                 
                tabla.Load(cmd.ExecuteReader());
                return tabla;
                
            }
            catch(SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                cmd.Parameters.Clear();
                CloseConnection();
                cmd.Parameters.Clear(); //Borra la lista de parametros para que la proxima vez que se haga una consulta no influya 
            }            
        }

        public void executeTransaction(string sqlTransaccion)
        {    
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlTransaccion;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) { 
          
                resultadoTransaccion = ResultadoTransaccion.fracaso;
                throw ex;
            }
        }

        public void beginTransaction()
        {
            tipoConexion = TipoConexion.transaccion;
            resultadoTransaccion = ResultadoTransaccion.exito;
            cnn.ConnectionString = string_conexion;
            cnn.Open();
            t = cnn.BeginTransaction();
            cmd.Connection = cnn;           
        } 


        //Este metodo sirve para cerrar la conexion con la BD, ya sea una transaccion o una conexion simple.
        public void CloseConnection()
        {
            if (tipoConexion == TipoConexion.transaccion)
            {
                if (resultadoTransaccion == ResultadoTransaccion.exito)
                {
                    t.Commit();
                    Console.WriteLine("La transaccion se realizo con exito...");
                }
                else
                {
                    t.Rollback();
                    Console.WriteLine("La transaccion no pudo realizarse...");
                }
            }
            tipoConexion = TipoConexion.simple;
            if(cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }
            
        }

        public int executeTransactionConParametros(string sqlTransaccion, Dictionary<string,object> parametros)
        {
            int afectadas = 0;
            try
            {
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlTransaccion;
                foreach (var p in parametros)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }
                afectadas=cmd.ExecuteNonQuery();
              
            }
            catch (Exception ex)
            {                
                resultadoTransaccion = ResultadoTransaccion.fracaso;
                throw ex;
            }
            finally
            {
                cmd.Parameters.Clear();
            }

            return afectadas;
        }


        public object ConsultaSQLScalar(string strSql)
        {            
            try
            {
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }
    }
}
