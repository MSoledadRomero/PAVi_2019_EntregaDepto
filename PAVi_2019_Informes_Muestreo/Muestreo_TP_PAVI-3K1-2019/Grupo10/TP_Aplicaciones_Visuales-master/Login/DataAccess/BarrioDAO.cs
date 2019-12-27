using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.AbstractClass;
using System.Data;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    class BarrioDAO : AbstractDataAccess
    {
       
        public IList<Barrio> getAll()
        {
            List<Barrio> listadoBarrio = new List<Barrio>();
            var consulta = "SELECT B.idBarrio, B.idCiudad, B.nombre, C.nombre AS nombreCiudad FROM Barrio B INNER JOIN Ciudad C ON B.idCiudad=C.idCiudad WHERE B.borrado=0"; //Todo: agregar el campo borrado a todas las tablas de la BD
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoBarrio.Add(mapping(row));
            }

            return listadoBarrio;
        }


        public DataTable getAllInTable()
        {
            
            var consulta = "SELECT B.idBarrio AS 'Código Barrio', B.nombre AS  Barrio, C.nombre AS Ciudad FROM Barrio B INNER JOIN Ciudad C ON B.idCiudad=C.idCiudad WHERE B.borrado=0"; //Todo: agregar el campo borrado a todas las tablas de la BD
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
            
        }

        public Barrio mapping(DataRow row)
        {
            Barrio oBarrio = new Barrio();
            oBarrio.IdBarrio = Convert.ToInt32(row["idBarrio"].ToString());
            oBarrio.IdCiudad = Convert.ToInt32(row["idCiudad"].ToString());
            oBarrio.Nombre = row["nombre"].ToString();

            return oBarrio;
        }

        //TODO: VER PARA QUE SIRVE
        /*
        public Barrio getProveedor(int id)
        {
            var dt = DBConexion.GetDBConexion().ConsultaSQL("select * from Barrio where idBarrio=" + id);
            return mapping(dt.Rows[0]);
        }*/

        public Barrio obtenerBarrioSinParametros(int id)
        {
            String sql = string.Concat("SELECT  B.idBarrio,  B.nombre, C.idCiudad, ",
                                        " C.nombre",
                                        " FROM Barrio B inner JOIN Ciudad C ON C.idCiudad=B.idCiudad " +
                                        " WHERE B.idBarrio=" + id + " AND B.borrado = 0 ");

            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }

        public Barrio obtenerBarrioConParametros(int id)
        {

            String sql = string.Concat("SELECT  B.idBarrio,  B.nombre, C.idCiudad, ",
                                        " C.nombre",
                                        " FROM Barrio B inner JOIN Ciudad C ON C.idCiudad=B.idCiudad " +
                                        " WHERE B.idBarrio=@id AND B.borrado = 0 ");

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", id);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;
        }


        public DataTable obtenerBarrioConParametros(Dictionary<string, object> parametros)
        {

            String sql = string.Concat(
                    "SELECT  B.idBarrio,  B.nombre,C.idCiudad, ",
                    "C.nombre",
                    " FROM Barrio B inner JOIN Ciudad C ON C.idCiudad=B.idCiudad " +
                    " WHERE B.borrado = 0 ");


            if (parametros.ContainsKey("idBarrio"))
            {
                sql += " AND B.idBarrio = @idBarrio ";
            }

            if (parametros.ContainsKey("idCiudad"))
            {
                sql += " AND B.idCiudad = @idCiudad";
            }
            if (parametros.ContainsKey("nombre"))
            {
                sql += " AND B.nombre = @nombre";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

            return resultado;
        }






        // Operaciones CRUD

        public bool insert(Barrio oBarrio)
        {
            string sql = @"INSERT INTO Barrio (idCiudad,nombre) 
                VALUES(" + oBarrio.IdCiudad +
                ",'" + oBarrio.Nombre +
                    "')";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }


        public bool update(Barrio oBarrio)
        {
            string sql = @"UPDATE Barrio " +
                "SET nombre='" + oBarrio.Nombre + "'," +
                "idCiudad=" + oBarrio.IdCiudad +
                " WHERE idBarrio=" + oBarrio.IdBarrio + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(Barrio oBarrio)
        {
            string sql = @"UPDATE Barrio SET borrado=1 WHERE idBarrio=" + oBarrio.IdBarrio + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Barrio SET borrado=1 WHERE idBarrio=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

    }
}
