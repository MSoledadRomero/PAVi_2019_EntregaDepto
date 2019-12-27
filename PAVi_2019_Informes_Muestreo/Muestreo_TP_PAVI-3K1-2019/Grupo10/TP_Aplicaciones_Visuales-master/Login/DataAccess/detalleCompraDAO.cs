using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.BusinessLayer;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.DataAccess
{
    public class DetalleCompraDAO
    {
        LibroService oLibroService = new LibroService();


        public void update(DetalleCompra DC)
        {
            Dictionary<String, object> parametros = new Dictionary<string, object>();
            oLibroService.actualizarLibro(DC.Libro);
            DBConexion.GetDBConexion().beginTransaction();

            int afectadas = 0;
            
            try
            {

                
                parametros.Add("idCompra", DC.IdCompra);
                
                parametros.Add("idLibro", DC.Libro.IdLibro);
                
                parametros.Add("cantidad", DC.Cantidad);
                parametros.Add("idDetalleCompra", DC.IdDetalleCompra);
                
                String sql = string.Concat("UPDATE DetalleCompra SET idCompra=@idCompra, idLibro=@idLibro," +
                                            " cantidad=@cantidad WHERE idDetalleCompra=@idDetalleCompra AND borrado=0");
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

        }


        public IList<DetalleCompra> GetByIdCompra(int idCompra)
        {
            List<DetalleCompra> listadoDetalleCompra = new List<DetalleCompra>();

            var strSql = " SELECT D.idCompra, D.idDetalleCompra, D.idLibro, D.cantidad, " +

            " L.Titulo , L.añoEdicion , L.estante, L.idAutor, L.idEditorial, L.idGenero, L.sector " +
    
            " FROM DetalleCompra D " +

            " INNER JOIN Libro L on L.idLibro = D.idLibro " +

            " WHERE D.borrado = 0  AND idCompra = " + idCompra;

            var resultado = DBConexion.GetDBConexion().ConsultaSQL(strSql);

            foreach (DataRow row in resultado.Rows)
            {
                listadoDetalleCompra.Add(MappingDetalleCompra(row));
            }

            return listadoDetalleCompra;
        }

        public void insert(DetalleCompra DC)
        {
         
            Dictionary<String, object> parametros = new Dictionary<string, object>();
            parametros.Add("idCompra", DC.IdCompra);
            parametros.Add("idLibro", DC.Libro.IdLibro);
            parametros.Add("cantidad", DC.Cantidad);
            var strSql = "INSERT DetalleCompra(idCompra,idLibro,cantidad) VALUES(@idCompra,@idLibro,@cantidad)";
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(strSql, parametros);
            oLibroService.insertarNuevoLibro(DC.Libro);
        }

        public void delete(int id)
        {
            var strSql = "delete DetalleCompra where idDetalleCompra = " + id;
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(strSql);
        }

        private DetalleCompra MappingDetalleCompra(DataRow row)
        {
            DetalleCompra oDetalleCompra = new DetalleCompra();
            oDetalleCompra.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
            oDetalleCompra.IdCompra = Convert.ToInt32(row["idCompra"].ToString());
            oDetalleCompra.IdDetalleCompra = Convert.ToInt32(row["idDetalleCompra"].ToString());
            
            oDetalleCompra.Libro= new Libro();
            oDetalleCompra.Libro.IdLibro = Convert.ToInt32(row["idLibro"].ToString());
            oDetalleCompra.Libro.Titulo = row["titulo"].ToString();
            oDetalleCompra.Libro.AñoEdicion = Convert.ToInt32(row["añoEdicion"].ToString());
            oDetalleCompra.Libro.Estante = Convert.ToInt32(row["estante"].ToString());
            oDetalleCompra.Libro.IdAutor = Convert.ToInt32(row["idAutor"].ToString());
            oDetalleCompra.Libro.IdEditorial = Convert.ToInt32(row["idEditorial"].ToString());
            oDetalleCompra.Libro.IdGenero = Convert.ToInt32(row["idGenero"].ToString());
            oDetalleCompra.Libro.Sector = row["sector"].ToString();


            return oDetalleCompra;
        }



    }
}
