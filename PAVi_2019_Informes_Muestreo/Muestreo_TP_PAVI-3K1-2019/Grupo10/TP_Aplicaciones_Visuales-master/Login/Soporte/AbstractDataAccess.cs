using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TP_Aplicaciones_Visuales.AbstractClass
{
    abstract class AbstractDataAccess
    {
        public DataTable excecuteStoreProcedure(string nombreProcedimiento)
        {
            return DBConexion.GetDBConexion().storeProcedureSql(nombreProcedimiento);
        }

        //public string[] getColumnNames(string nombreProcedimiento)
        //{
        //    DataTable tabla = excecuteStoreProcedure(nombreProcedimiento);
        //    string[] columnNames= new string[(tabla.Columns.Count)];
        //    int i=0;
        //    foreach(DataColumn col in tabla.Columns)
        //    {
        //        columnNames[i]=col.ColumnName;
        //        i++;
        //    }
        //    return columnNames;

        //}



        //public string[] getRealColumnNamesOfTable(string table)
        //{
        //    var sql = "SELECT TOP 0 * FROM "+table+"";
     
        //    DataTable tabla = DBConexion.GetDBConexion().ConsultaSQL(sql);
        //    string[] realColumnNames = new string[(tabla.Columns.Count)];
        //    int i = 0;
            
        //    foreach (DataColumn c in tabla.Columns)
        //    {                           
        //          realColumnNames[i] = c.ToString();
        //          i++;        
               
        //    }
        //    return realColumnNames;
        //}


        //Este metodo esta hecho de forma general, para poder obtener el ultimo de cualquier dato, por eso devuelve string

        public string ObtenerUltimo(string columna, string tabla)
        {
            

            var strSql = "SELECT MAX(" + columna + ") from " + tabla + "";
            var filaResultadoConsulta = DBConexion.GetDBConexion().ConsultaSQL(strSql).Rows[0][0].ToString();

            //ConsultaSQL devuelve un dataTable entonces accedo a su vector de filas
            //Le pido la fila 0 y la columna 0
            return filaResultadoConsulta;

        }
    }
}
