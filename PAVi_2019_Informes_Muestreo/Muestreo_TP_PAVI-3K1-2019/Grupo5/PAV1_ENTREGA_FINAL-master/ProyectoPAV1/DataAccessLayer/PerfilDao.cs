using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPAV1.Entities;
using System.Data;


namespace ProyectoPAV1.DataAccessLayer
{
    public class PerfilDao
    {
        public IList<Perfil> GetAll()
        {
            List<Perfil> listadoBugs = new List<Perfil>();

            var strSql = "SELECT * From Perfiles WHERE id_perfil <> 1 AND borrado=0";

            var resultadoConsulta = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }

            return listadoBugs;
        }

        private Perfil ObjectMapping(DataRow row)
        {
            Perfil oPerfil = new Perfil
            {
                IdPerfil = Convert.ToInt32(row["id_Perfil"].ToString()),
                Nombre = row["nombre"].ToString()
            };

            return oPerfil;
        }
        public IList<Perfil> GetByFilters(String condiciones)
        {

            List<Perfil> lst = new List<Perfil>();
            String strSql = string.Concat(" SELECT id_Perfil, ",
                                              "        nombre ",
                                              "   FROM Perfiles",
                                              "  WHERE borrado =0 ");



            strSql += condiciones;


            // if (parametros.ContainsKey("usuario"))
            //    strSql += " AND (u.usuario LIKE '%' + @usuario + '%') ";

            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);


            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }


        public Perfil GetPerfil(string Nombre)
        {

            String strSql = string.Concat(" SELECT id_perfil, ",
                                          "        nombre ",
                                          "  FROM Perfiles WHERE borrado =0 ");

            strSql += " AND nombre=" + "'" + Nombre + "'";

            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(strSql);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        internal bool Create(Perfil oPerfil)
        {
            //modificar

            string str_sql = "INSERT INTO Perfiles (nombre, borrado)" +
                            " VALUES (" +
                            "'" + oPerfil.Nombre + "'" +
                            ",0)";


            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        internal bool Update(Perfil oPerfil)
        {
            //SIN PARAMETROS

            string str_sql = "UPDATE Perfiles " +
                             "SET nombre=" + "'" + oPerfil.Nombre + "'" +
                             " WHERE id_perfil=" + oPerfil.IdPerfil;

            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }

        internal bool Delete(Perfil oPerfil)
        {
            string str_sql = "UPDATE Perfiles " +
                             "SET borrado=" + "'" + true + "'" +
                             " WHERE id_perfil=" + oPerfil.IdPerfil;


            return (DBHelper.GetDBHelper().EjecutarSQL(str_sql) == 1);
        }
    }
}
