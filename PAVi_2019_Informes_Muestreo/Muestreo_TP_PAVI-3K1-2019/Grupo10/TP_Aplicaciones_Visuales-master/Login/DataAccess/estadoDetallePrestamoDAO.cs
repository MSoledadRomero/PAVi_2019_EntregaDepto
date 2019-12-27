using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    public class EstadoDetallePrestamoDAO
    {

        public IList<EstadoDetallePrestamo> getAll()
        {
            List<EstadoDetallePrestamo> listadoEstadoDetallePrestamo = new List<EstadoDetallePrestamo>();
            var consulta = "SELECT idEstadoEjemplar, nombre FROM EstadoPrestamo WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoEstadoDetallePrestamo.Add(mapping(row));
            }

            return listadoEstadoDetallePrestamo;
        }
        public DataTable obtenerTodos()
        {

            var consulta = "SELECT * FROM EstadoDetallePrestamo WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);

            return resultado;
        }
        public EstadoDetallePrestamo mapping(DataRow row)
        {
            EstadoDetallePrestamo oEstadoDetallePrestamo = new EstadoDetallePrestamo();
            oEstadoDetallePrestamo.IdEstadoDetalle = Convert.ToInt32(row["idEstadoDetallePrestamo"].ToString());
            oEstadoDetallePrestamo.Nombre = row["nombre"].ToString();
            return oEstadoDetallePrestamo;
        }
    }
}
