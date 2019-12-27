using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    class EstadoPrestamoDAO
    {
 
        public IList<EstadoPrestamo> getAll()
        {
            List<EstadoPrestamo> listadoEstadoPrestamo = new List<EstadoPrestamo>();
            var consulta = "SELECT idEstadoEjemplar, nombre FROM EstadoPrestamo WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoEstadoPrestamo.Add(mapping(row));
            }

            return listadoEstadoPrestamo;
        }
        public DataTable obtenerTodos()
        {
            
            var consulta = "SELECT * FROM EstadoPrestamo WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
        
            return resultado;
        }
        public EstadoPrestamo mapping(DataRow row)
        {
            EstadoPrestamo oEstadoPrestamo = new EstadoPrestamo();
            oEstadoPrestamo.IdEstadoPrestamo = Convert.ToInt32(row["idEstadoPrestamo"].ToString());
            oEstadoPrestamo.Nombre = row["nombre"].ToString();
            return oEstadoPrestamo;
        }
    }
}
