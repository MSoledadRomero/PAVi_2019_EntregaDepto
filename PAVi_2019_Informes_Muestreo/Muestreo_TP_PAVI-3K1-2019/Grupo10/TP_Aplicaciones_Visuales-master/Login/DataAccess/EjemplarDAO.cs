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
    class EjemplarDAO : AbstractDataAccess
    {
        public IList<Ejemplar> getAll()
        {
            List<Ejemplar> listadoEjemplar = new List<Ejemplar>();
            var consulta = "SELECT E.idEjemplar, E.idLibro, E.idEstadoEjemplar ,EE.nombre FROM Ejemplar E inner JOIN EstadoEjemplar EE ON EE.idEstadoEjemplar=E.idEstadoEjemplar WHERE E.borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoEjemplar.Add(mapping(row));
            }

            return listadoEjemplar;
        }
        
        public Ejemplar mapping(DataRow row)
        {
            Ejemplar oEjemplar = new Ejemplar();
            oEjemplar.IdEjemplar = Convert.ToInt32(row["idEjemplar"].ToString());
            oEjemplar.IdLibro = Convert.ToInt32(row["idLibro"].ToString());
            oEjemplar.IdEstadoEjemplar = Convert.ToInt32(row["idEstadoEjemplar"].ToString());
            return oEjemplar;
        }

        public Ejemplar obtenerEjemplarSinParametros(int id)
        {
            String sql = string.Concat("SELECT idEjemplar, idLibro, idEstadoEjemplar FROM Ejemplar WHERE idEjemplar="+id+" AND borrado=0");
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

        public DataTable obtenerEjemplaresPorLibro(int idLibro)
        {
            
            String sql = string.Concat("SELECT E.idEjemplar AS 'Código Ejemplar', EE.nombre AS 'Estado' FROM Ejemplar E inner JOIN EstadoEjemplar EE ON EE.idEstadoEjemplar=E.idEstadoEjemplar WHERE E.idLibro="+idLibro+" AND E.borrado=0");
            return DBConexion.GetDBConexion().ConsultaSQL(sql);
            
        }

        public Ejemplar obtenerEjemplarConParametros(int id)
        {
            String sql = string.Concat("SELECT idEjemplar, idLibro, idEstadoEjemplar FROM Ejemplar WHERE idEjemplar=@id AND borrado=0");
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }

        public DataTable obtenerEjemplarConParametros(Dictionary<string, object> parametros)
        {            
            String sql = string.Concat("SELECT idEjemplar, idLibro, idEstadoEjemplar FROM Ejemplar WHERE borrado=0");

            if (parametros.ContainsKey("idEjemplar"))
            {
                sql += " AND idEjemplar = @idEjemplar ";
            }
            if (parametros.ContainsKey("idLibro"))
            {
                sql += " AND idLibro = @idLibro";
            }
            if (parametros.ContainsKey("idEstadoEjemplar"))
            {
                sql += " AND idEstadoEjemplar = @idEstadoEjemplar";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);          

            return resultado;
        }


        // Operaciones CRUD

        public bool insert(Ejemplar oEjemplar)
        {
            string sql = @"INSERT INTO Ejemplar (idLibro,idEstadoEjemplar) VALUES ("+oEjemplar.IdLibro+","+oEjemplar.IdEstadoEjemplar+")";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool update(Ejemplar oEjemplar)
        {
            string sql = @"UPDATE  Ejemplar SET idLibro=" + oEjemplar.IdLibro + " " +
                        "WHERE idEstadoEjemplar=" + oEjemplar.IdEstadoEjemplar + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Ejemplar oEjemplar)
        {
            string sql = @"UPDATE Ejemplar SET borrado=1 WHERE idEjemplar=" + oEjemplar.IdEjemplar + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Ejemplar SET borrado=1 WHERE idEjemplar=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }


    }
}
