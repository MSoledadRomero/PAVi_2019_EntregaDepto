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
    class LibroDAO : AbstractDataAccess
    {
        private readonly EjemplarDAO oEjemplarDAO= new EjemplarDAO(); //tODO: VER SI ESTO ES CORRECTO
        public IList<Libro> getAll()
        {
            List<Libro> listadoLibro = new List<Libro>();
            //var consulta = "SELECT L.idLibro AS ID, L.titulo AS Titulo, L.añoEdicion AS Año, L.idGenero AS Genero, L.idAutor AS Autor, L.idEditorial AS Editorial, L.sector AS Sector, L.estante AS Estante FROM Libro L WHERE borrado=0";
            var consulta = "SELECT idLibro, titulo, añoEdicion, idGenero, idAutor, idEditorial, sector, estante" +
                          " FROM Libro WHERE borrado=0";
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(consulta);
            foreach (DataRow row in resultado.Rows)
            {
                listadoLibro.Add(mapping(row));
            }

            return listadoLibro;
        }

        public DataTable getAllInTable()
        {
            var consulta = "SELECT L.idLibro AS 'Código', L.titulo AS 'Titulo', L.añoEdicion AS 'Edición', G.nombre AS 'Género', A.nombre AS 'Autor', E.nombreEditorial AS 'Editorial', sector AS 'Sector', estante AS 'Estante'" +
                         " FROM Libro L JOIN Genero G ON L.idGenero = G.idGenero JOIN Autor A ON L.idAutor = A.idAutor " +
                         " JOIN Editorial E ON L.idEditorial = E.idEditorial WHERE L.borrado=0";
            return DBConexion.GetDBConexion().ConsultaSQL(consulta);
        }

        public Libro mapping(DataRow row)
        {
            Libro oLibro = new Libro();
            oLibro.IdLibro = Convert.ToInt32(row["idLibro"].ToString());
            oLibro.Titulo = row["titulo"].ToString();
            oLibro.AñoEdicion = Convert.ToInt32(row["añoEdicion"].ToString());
            oLibro.IdGenero = Convert.ToInt32(row["idGenero"].ToString());
            oLibro.IdAutor = Convert.ToInt32(row["idAutor"].ToString());
            oLibro.IdEditorial = Convert.ToInt32(row["idEditorial"].ToString());
            oLibro.Sector = row["sector"].ToString();
            oLibro.Estante = Convert.ToInt32(row["estante"].ToString());
            return oLibro;
        }


        public Libro obtenerLibroSinParametros(int id)
        {
            //String sql = string.Concat("SELECT L.idLibro AS ID, L.titulo AS Titulo, L.añoEdicion AS Año, L.idGenero AS Genero, L.idAutor AS Autor, L.idEditorial AS Editorial, L.sector AS Sector, L.estante AS Estante ",
            //                            "FROM Libro L JOIN Genero G ON L.idGenero = G.idGenero " +
            //                            "JOIN Autor A ON L.idAutor = A.idAutor " +
            //                            "JOIN Editorial E ON L.idEditorial = E.idEditorial " +
            //                            "WHERE L.idLibro="+ id +" AND L.borrado = 0");


            String sql = string.Concat("SELECT L.idLibro, L.titulo, L.añoEdicion, L.idGenero, L.idAutor, L.idEditorial, L.sector, L.estante ",
                                        "FROM Libro L " +
                                        "JOIN Genero G ON L.idGenero = G.idGenero " +
                                        "JOIN Autor A ON L.idAutor = A.idAutor " +
                                        "JOIN Editorial E ON L.idEditorial = E.idEditorial " +
                                        "WHERE L.idLibro=" + id + " AND L.borrado = 0");

            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);
            }
            return null;

        }



        //Retorno un IList porque quiero que este metodo sea por sobrecarga asi no hay tantos direfentes
        //De todas formas ese List se sabe que siempre va a tener un solo libro

        public Libro obtenerLibroConParametros(int idLibro)
        {

            //String sql = string.Concat("SELECT L.idLibro AS ID, L.titulo AS Titulo, L.añoEdicion AS Año, L.idGenero AS Genero, L.idAutor AS Autor, L.idEditorial AS Editorial, L.sector AS Sector, L.estante AS Estante ",
            //                            "FROM Libro L JOIN Genero G ON L.idGenero = G.idGenero " +
            //                            "JOIN Autor A ON L.idAutor = A.idAutor " +
            //                            "JOIN Editorial E ON L.idEditorial = E.idEditorial " +
            //                            "WHERE L.idLibro = @id AND L.borrado=0");

            String sql = string.Concat("SELECT L.idLibro, L.titulo, L.añoEdicion, L.idGenero, L.idAutor, L.idEditorial, L.sector, L.estante ",
                                        "FROM Libro L JOIN Genero G ON L.idGenero = G.idGenero " +
                                        "JOIN Autor A ON L.idAutor = A.idAutor " +
                                        "JOIN Editorial E ON L.idEditorial = E.idEditorial " +
                                        "WHERE L.idLibro = @id AND L.borrado=0");


            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("id", idLibro);
            DataTable resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);
            if (resultado.Rows.Count > 0)
            {
                return mapping(resultado.Rows[0]);                
            }
            return null;

        }

        public DataTable obtenerLibroConParametros(Dictionary<string, object> parametros) //Todo: hacer sobrecarga
        {

            List<Libro> libros = new List<Libro>();

            //String sql = string.Concat("SELECT idLibro AS ID, titulo AS Titulo, añoEdicion AS Edicion,G.nombre AS Genero ,A.nombre AS Autor, ", 
            //                        " E.nombreEditorial AS Editorial, sector AS Sector, estante AS Estante FROM Libro L ",
            //                        "inner join  Genero G on G.idGenero = L.idEditorial ",
            //                        " inner join  Autor A on A.idAutor = L.idAutor ",
            //                        " inner join  Editorial E on E.idEditorial = L.idEditorial ",
            //                        " WHERE  L.borrado = 0");

            String sql = string.Concat("SELECT idLibro, titulo, añoEdicion, G.nombre, A.nombre, ",
                                    " E.nombreEditorial, sector, estante FROM Libro L ",
                                    "inner join  Genero G on G.idGenero = L.idEditorial ",
                                    " inner join  Autor A on A.idAutor = L.idAutor ",
                                    " inner join  Editorial E on E.idEditorial = L.idEditorial ",
                                    " WHERE  L.borrado = 0");

            if (parametros.ContainsKey("tituloLibro"))
                sql += " AND L.titulo = @tituloLibro "; //Todo:LIKE


            if (parametros.ContainsKey("añoEdicion"))
                sql += " AND  L.añoEdicion= @añoEdicion ";

            if (parametros.ContainsKey("genero"))
                sql += " AND  L.idGenero=@genero ";

            if (parametros.ContainsKey("autor"))
                sql += " AND  L.idAutor=@autor ";

            if (parametros.ContainsKey("editorial"))
                sql += " AND  L.idEditorial=@editorial ";


            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);


            //foreach (DataRow row in resultado.Rows)
            //{
            //    libros.Add(Mapping(row));
            //    return libros;
            //}
            return resultado;
        }


        // Operaciones CRUD

       
        public bool insert(List<Ejemplar> ejemplares, Libro oLibro)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            
            parametros.Add("titulo", oLibro.Titulo);
            parametros.Add("añoEdicion", oLibro.AñoEdicion);
            parametros.Add("idGenero", oLibro.IdGenero);
            parametros.Add("idAutor", oLibro.IdAutor);
            parametros.Add("idEditorial", oLibro.IdEditorial);
            parametros.Add("sector", oLibro.Sector);
            parametros.Add("estante", oLibro.Estante);
            
            String sql = string.Concat("INSERT INTO Libro (titulo,añoEdicion, idGenero,idAutor, idEditorial, sector, estante) " +
                                        "VALUES (@titulo,@añoEdicion,@idGenero,@idAutor,@idEditorial,@sector,@estante)");

            DBConexion.GetDBConexion().beginTransaction();
            int afectadas = 0;
            try
            {
                afectadas=DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);                
                var newId = DBConexion.GetDBConexion().ConsultaSQLScalar(" SELECT @@IDENTITY");

                foreach (Ejemplar e in ejemplares)
                {
                    
                    parametros.Clear();
                    e.IdLibro = Convert.ToInt32(newId);
                    parametros.Add("idEjemplar", e.IdEjemplar);
                    parametros.Add("idLibro", e.IdLibro);
                    parametros.Add("idEstadoEjemplar", e.IdEstadoEjemplar);
                    sql = "";
                    sql = String.Concat("INSERT INTO Ejemplar (idEjemplar,idLibro,idEstadoEjemplar) " +
                                            " VALUES (@idEjemplar,@idLibro,@idEstadoEjemplar)");
                    afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                    
                }

            }
            catch(Exception ex)
            {
                throw ex; 
            }
            finally
            {
                DBConexion.GetDBConexion().CloseConnection();
            }
            return (afectadas!=0);
        }

        public bool insert(Libro oLibro)
        {
            string sql = @"INSERT INTO Libro (titulo,añoEdicion, idGenero,idAutor, idEditorial, sector, estante) VALUES ('" + oLibro.Titulo + 
                        "', " + oLibro.AñoEdicion + 
                        ", " + oLibro.IdGenero + 
                        ", " + oLibro.IdAutor + 
                        ", " + oLibro.IdEditorial + 
                        ", '" + oLibro.Sector + 
                        "', " + oLibro.Estante + ")";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);

        }

        public bool updateAndInsertEjemplares(List<Ejemplar> ejemplares, Libro oLibro)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            bool[] existencia= new bool[ejemplares.Count]; //Esto lo voy a cargar con bool para saber si el ejemplar ya existe o no
            //Esto lo hago porque no puedo ejecutar el consultar dentro del la transaccion, porque la cadena ya esta asignada y este metodo intenta asignarlanuevamente
            //entonces lo tengo que hacer si o si antes del beginTransaction
            parametros.Add("idLibro", oLibro.IdLibro);
            parametros.Add("titulo", oLibro.Titulo);
            parametros.Add("añoEdicion", oLibro.AñoEdicion);
            parametros.Add("idGenero", oLibro.IdGenero);
            parametros.Add("idAutor", oLibro.IdAutor);
            parametros.Add("idEditorial", oLibro.IdEditorial);
            parametros.Add("sector", oLibro.Sector);
            parametros.Add("estante", oLibro.Estante);

            String sql = string.Concat("UPDATE Libro SET titulo=@titulo, añoEdicion=@añoEdicion," +
                                        " idGenero=@idGenero, idAutor=@idAutor, idEditorial=@idEditorial," +
                                        " sector=@sector, estante=@estante WHERE idLibro=@idLibro AND borrado=0");



            //Veo si los ejemplares existen
            int i = 0;

           
            DBConexion.GetDBConexion().beginTransaction();
            int afectadas = 0;
            i = 0;
            try
            {
                afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                //var newId = DBConexion.GetDBConexion().ConsultaSQLScalar(" SELECT @@IDENTITY");

                foreach (Ejemplar e in ejemplares)
                {
                    parametros.Clear();
                    //e.IdLibro = Convert.ToInt32(newId);
                    parametros.Add("idEjemplar", e.IdEjemplar);
                    parametros.Add("idLibro", e.IdLibro);
                    parametros.Add("idEstadoEjemplar", e.IdEstadoEjemplar);
                    sql = "";
                    sql = String.Concat("INSERT INTO Ejemplar (idEjemplar,idLibro,idEstadoEjemplar) " +
                                            " VALUES (@idEjemplar,@idLibro,@idEstadoEjemplar)");
                    afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                    i++;
                }
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

        public bool update(Libro oLibro)
        {
            string sql = @"UPDATE Libro SET titulo='" + oLibro.Titulo + "'," +
                         "añoEdicion=" + oLibro.AñoEdicion + "," +
                         "idGenero=" + oLibro.IdGenero + "," +
                         "idAutor=" + oLibro.IdAutor + "," +
                         "idEditorial=" + oLibro.IdEditorial + ", " +
                         "sector='" + oLibro.Sector + "', " +
                         "estante=" + oLibro.Estante + " " +
                         "WHERE idLibro=" + oLibro.IdLibro + " AND borrado=0";  

            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);

        }



        public bool logicalDelete(int id)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("idLibro", id);            

            String sql = string.Concat("UPDATE Libro SET borrado=1 WHERE idLibro=@idLibro AND borrado=0");

            DBConexion.GetDBConexion().beginTransaction();
            int afectadas = 0;
            try
            {
                afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                sql = String.Concat("UPDATE Ejemplar SET borrado=1 WHERE idLibro=@idLibro AND borrado=0");
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

        public bool logicalDelete(Libro oLibro)
        {
            string sql = @"UPDATE Libro SET borrado=1 WHERE idLibro=" + oLibro.IdLibro + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);
        }

        /*public bool logicalDelete(int id)
        {
            string sql = @"UPDATE Libro SET borrado=1 WHERE idLibro=" + id + " AND borrado=0";
            return ((DBConexion.GetDBConexion().ExecuteSQL(sql)) == 1);

        }*/
    }
}
