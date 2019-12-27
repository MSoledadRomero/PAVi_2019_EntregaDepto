using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.AbstractClass;
using TP_Aplicaciones_Visuales.Entities;
using System.Data;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    class EstadoEjemplarDAO : AbstractDataAccess //Esta no la hice dericar de la clase abstracta porque no le hacen falta esos metodos
    {

        public IList<EstadoEjemplar> getAll()
        {
            List<EstadoEjemplar> listadoEstadoEjemplar = new List<EstadoEjemplar>();
            var consulta = "SELECT idEstadoEjemplar, nombre FROM EstadoEjemplar WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoEstadoEjemplar.Add(mapping(row));
            }

            return listadoEstadoEjemplar;
        }

        public EstadoEjemplar mapping(DataRow row)
        {
            EstadoEjemplar oEstadoEjemplar = new EstadoEjemplar();
            oEstadoEjemplar.IdEstadoEjemplar = Convert.ToInt32(row["idEstadoEjemplar"].ToString());
            oEstadoEjemplar.Nombre = row["nombre"].ToString();                
            return oEstadoEjemplar;
        }




        public EstadoEjemplar obtenerEstadoEjemplarSinParametros(string nombre)
        {
            string sql = string.Concat("SELECT idEstadoEjemplar, nombre FROM EstadoEjemplar WHERE nombre='"+nombre+"' AND borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);               
            }
            return null;

        }


        public EstadoEjemplar obtenerEstadoEjemplarSinParametros(int id)
        {
            String sql = string.Concat("SELECT idEstadoEjemplar, nombre FROM EstadoEjemplar WHERE idEstadoEjemplar='" + id + "' AND borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

        // Operaciones CRUD

        public bool insert(EstadoEjemplar oEstadoEjemplar)
        {
            string sql = @"INSERT INTO EstadoEjemplar (nombre) VALUES ('" + oEstadoEjemplar.Nombre + "')";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool update(EstadoEjemplar oEstadoEjemplar)
        {
            string sql = @"UPDATE EstadoEjemplar SET nombre='" + oEstadoEjemplar.Nombre + "' " +
                        "WHERE idEstadoEjemplar=" + oEstadoEjemplar.IdEstadoEjemplar + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(EstadoEjemplar oEstadoEjemplar)
        {
            string sql = @"UPDATE EstadoEjemplar SET borrado=1 WHERE idEstadoEjemplar=" + oEstadoEjemplar.IdEstadoEjemplar + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE EstadoEjemplar SET borrado=1 WHERE idEstadoEjemplar=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }
    }
}
