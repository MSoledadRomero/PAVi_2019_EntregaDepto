using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.Entities;


namespace TP_Aplicaciones_Visuales.DataAccess
{
    class DetallePrestamoDAO
    {




        public DetallePrestamo mapping(DataRow row)
        {
            DetallePrestamo oDetallePrestamo = new DetallePrestamo();
            //Validamos que la fecha este cargada antes de mapear, la fecha de devolucion 
            //es la fecha en la que se devolvio el libro y no la fecha limite por eso es 
            //null al principio

            if (row["fechaDevolucion"] != DBNull.Value)
            {
                oDetallePrestamo.FechaDevolucion = Convert.ToDateTime(row["fechaDevolucion"].ToString());
            }
            Console.WriteLine("El numero de ejemplar es : " + Convert.ToInt32(row["idEjemplar"].ToString()));
            oDetallePrestamo.IdEjemplar = Convert.ToInt32(row["idEjemplar"].ToString());
            oDetallePrestamo.IdPrestamo = Convert.ToInt32(row["idPrestamo"].ToString());
            oDetallePrestamo.IdLibro = Convert.ToInt32(row["idLibro"].ToString());
            oDetallePrestamo.IdEstadoDetallePrestamo = Convert.ToInt32(row["idEstadoDetallePrestamo"].ToString());
            return oDetallePrestamo;
        }

        public IList<DetallePrestamo> getAllPorIDPrestamo(int id)
        {
            List<DetallePrestamo> listadoDetallePrestamo = new List<DetallePrestamo>();
            var consulta = "SELECT * FROM DetallePrestamo WHERE borrado=0 and idPrestamo = " + id;
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoDetallePrestamo.Add(mapping(row));
            }
            return listadoDetallePrestamo;
        }
        // Operaciones CRUD

        public bool insert(DetallePrestamo oDetallePrestamo)
        {
                string sql = @"INSERT INTO DetallePrestamo (idPrestamo,idEstadoDetallePrestamo,idEjemplar, idLibro,fechaDevolucion,)" 
                                      + "VALUES (" + oDetallePrestamo.IdPrestamo + "," + oDetallePrestamo.IdEstadoDetallePrestamo + ","
                                      + oDetallePrestamo.IdEjemplar + "," + oDetallePrestamo.IdLibro + "," + oDetallePrestamo.FechaDevolucion + ")";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        internal bool Update(DetallePrestamo oDetallePrestamo)
        {
            //SIN PARAMETROS
            string str_sql = "UPDATE DetallePrestamo " +
                             " SET idPrestamo=" + oDetallePrestamo.IdPrestamo + "," +
                             " idEstadoDetallePrestamo="  + oDetallePrestamo.IdEstadoDetallePrestamo +  "," +
                             " idEjemplar=" + oDetallePrestamo.IdEjemplar+  "," +
                             " idLibro=" + oDetallePrestamo.IdLibro+  "," +
                             " fechaDevolucion=" + oDetallePrestamo.FechaDevolucion +
                             " WHERE idDetallePrestamo=" + oDetallePrestamo;
            return (DBConexion.GetDBConexion().ExecuteSQL(str_sql) == 1);
        }
    }
}
