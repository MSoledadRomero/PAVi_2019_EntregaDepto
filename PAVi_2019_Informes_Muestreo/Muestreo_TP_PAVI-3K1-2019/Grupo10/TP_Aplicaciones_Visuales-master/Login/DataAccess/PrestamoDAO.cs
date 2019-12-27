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
    public  class PrestamoDAO
    {

        DetallePrestamoService oDetallePrestamoService;
        public PrestamoDAO()
        {
            oDetallePrestamoService = new DetallePrestamoService();
        }

        public Prestamo obtenerPorIDPrestamo(int id)
        {
            String sql = string.Concat("SELECT idPrestamo,idSocio,idEstadoPrestamo,fechaPrestamo,fechaLimite FROM Prestamo WHERE borrado=0 and idPrestamo = " + id);
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);
            if (resultado.Rows.Count > 0)
            {
                Prestamo oPrestamo = mapping(resultado.Rows[0]);
                oPrestamo.ListaDeDetalles = oDetallePrestamoService.getAllPorIDPrestamo(oPrestamo.IdPrestamo);
                return oPrestamo;
            }
            return null;
        }

        public Prestamo obtenerPorIDSocio(int id)
        {
            String sql = string.Concat("SELECT idPrestamo,idSocio,idEstadoPrestamo,fechaPrestamo,fechaLimite FROM Prestamo WHERE borrado=0 and idSocio = " + id);
            var resultado = DBConexion.GetDBConexion().ConsultaSQL(sql);

            if (resultado.Rows.Count > 0)
            {
                Prestamo oPrestamo = mapping(resultado.Rows[0]);
                oPrestamo.ListaDeDetalles = oDetallePrestamoService.getAllPorIDPrestamo(oPrestamo.IdPrestamo);
                return oPrestamo;
            }
            return null;
        }

        public Prestamo mapping(DataRow row)
        {
            Prestamo oPrestamo = new Prestamo();
            oPrestamo.IdPrestamo = Convert.ToInt32(row["idPrestamo"].ToString());
            oPrestamo.IdSocio = Convert.ToInt32(row["idSocio"].ToString());
            oPrestamo.IdEstadoPrestamo = Convert.ToInt32(row["idEstadoPrestamo"].ToString());
            oPrestamo.FechaPrestamo = Convert.ToDateTime(row["fechaPrestamo"].ToString());
            oPrestamo.FechaLimite = Convert.ToDateTime(row["fechaLimite"].ToString());
            return oPrestamo;
        }


        public DataTable obtenerPrestamoConParametros(Dictionary<string, object> parametros)
        {
            String sql = "select P.idPrestamo as ID,S.nombre as Socio , E.nombre as 'Estado del prestamo',fechaPrestamo as 'Fecha de prestamo'  ,fechaLimite as 'Fecha limite'  from Prestamo P inner join Socio S on S.idSocio = P.idSocio inner join EstadoPrestamo E on E.idEstadoPrestamo = P.idEstadoPrestamo where P.borrado = 0 ";

            if (parametros.ContainsKey("fechaPrestamo"))
            {
                sql += " AND P.fechaPrestamo >=  @fechaPrestamo";
            }
            if (parametros.ContainsKey("fechaLimite"))
            {
                sql += " AND P.fechaLimite <= @fechaLimite ";
            }

            if (parametros.ContainsKey("idEstadoPrestamo"))
            {
                sql += " AND P.idEstadoPrestamo = @idEstadoPrestamo";
            }
            if (parametros.ContainsKey("idSocio"))
            {
                sql += " AND P.idSocio = @idSocio";
            }

            if (parametros.ContainsKey("idPrestamo"))
            {
                sql += " AND P.idPrestamo = @idPrestamo";
            }
            var resultado = DBConexion.GetDBConexion().ConsultaSQLConParametros(sql, parametros);

            return resultado;
        }
        public bool insert(Prestamo oPrestamo)
        {

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idPrestamo", oPrestamo.IdPrestamo);
            parametros.Add("idSocio", oPrestamo.IdSocio);
            parametros.Add("idEstadoPrestamo", oPrestamo.IdEstadoPrestamo);
            parametros.Add("fechaPrestamo", oPrestamo.FechaPrestamo);
            parametros.Add("fechaLimite", oPrestamo.FechaLimite);
            String sql = string.Concat("INSERT INTO Prestamo (idSocio, idEstadoPrestamo,fechaPrestamo, fechaLimite) " +
                                        "VALUES (@idSocio,@idEstadoPrestamo,@fechaPrestamo,@fechaLimite)");
            DBConexion.GetDBConexion().beginTransaction();
            int afectadas = 0;
            try
            {
                afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                var IDConIdentity = DBConexion.GetDBConexion().ConsultaSQLScalar(" SELECT @@IDENTITY");

                foreach (DetallePrestamo detallePrestamo in oPrestamo.ListaDeDetalles)
                {
                    parametros.Clear();
                    detallePrestamo.IdPrestamo = Convert.ToInt32(IDConIdentity);
                    parametros.Add("idPrestamo", detallePrestamo.IdPrestamo);
                    parametros.Add("idEstadoDetallePrestamo", detallePrestamo.IdEstadoDetallePrestamo);
                    parametros.Add("idEjemplar", detallePrestamo.IdEjemplar);
                    parametros.Add("idLibro", detallePrestamo.IdLibro);
                    sql = "";
                    sql = String.Concat("INSERT INTO DetallePrestamo (idPrestamo, idEstadoDetallePrestamo, idEjemplar, idLibro) " +
                                    " VALUES (@idPrestamo,@idEstadoDetallePrestamo,@idEjemplar,@idLibro)");
                    afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                    parametros.Clear();
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


        public bool update(Prestamo oPrestamo)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("idPrestamo", oPrestamo.IdPrestamo);
            parametros.Add("idEstadoPrestamo", oPrestamo.IdEstadoPrestamo);
        
            String sql = string.Concat("UPDATE Prestamo  " +
                                        "set idEstadoPrestamo = @idEstadoPrestamo where idPrestamo = @idPrestamo");
            DBConexion.GetDBConexion().beginTransaction();
            int afectadas = 0;
            try
            {
                afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                foreach (DetallePrestamo detallePrestamo in oPrestamo.ListaDeDetalles)
                {
                    parametros.Clear();
                    parametros.Add("idPrestamo", oPrestamo.IdPrestamo);
                    parametros.Add("idEstadoDetallePrestamo", detallePrestamo.IdEstadoDetallePrestamo);
                   
                    //if (detallePrestamo.FechaDevolucion != null)
                    //{
                    //    parametros.Add("fechaDevolucion", detallePrestamo.FechaDevolucion);
                    //}
                    sql = "";
                    sql = String.Concat("UPDATE  DetallePrestamo SET idEstadoDetallePrestamo = @idEstadoDetallePrestamo where idPrestamo = @idPrestamo ");

                    //if (parametros.ContainsKey("fechaDevolucion"))
                    //{
                    //    sql += " fechaDevolucion = @fechaDevolucion ";
                    //}
                    //sql += " where idPrestamo = @idPrestamo";
                    
                    afectadas = DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);
                    parametros.Clear();
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




        public bool create(Prestamo prestamo)
       {
          try
           {
               //dm.Open();
               DBConexion.GetDBConexion().beginTransaction();

               string sql = string.Concat("INSERT INTO [dbo].[Prestamo] ",
                                           "           ([fechaPrestamo]   ",
                                           "           ,[fechaLimite]         ",
                                           "           ,[idSocio]         ",
                                           "           ,[idEstadoPrestamo]         ",
                                           "           ,[borrado])      ",
                                           "     VALUES                 ",
                                           "           (@fechaPrestamo   ",
                                           "           ,@fechaLimite     ",
                                           "           ,@idSocio     ",
                                           "           ,@idEstadoPrestamo     ",
                                           "           ,@borrado)       ");


               var parametros = new Dictionary<string, object>();
               parametros.Add("fechaPrestamo", prestamo.FechaPrestamo);
               parametros.Add("fechaLimite", prestamo.FechaLimite);
               parametros.Add("idSocio", prestamo.IdSocio);
               parametros.Add("idEstadoPrestamo", prestamo.IdEstadoPrestamo);
               parametros.Add("borrado", false);
               DBConexion.GetDBConexion().executeTransactionConParametros(sql, parametros);

               var newId = DBConexion.GetDBConexion().ConsultaSQLScalar(" SELECT @@IDENTITY"); //ver
               prestamo.IdPrestamo = Convert.ToInt32(newId);


               foreach (var itemPrestamo in prestamo.ListaDeDetalles)
               {
                   if (itemPrestamo.ToString() != null)
                   {


                       string sqlDetalle = string.Concat(" INSERT INTO [dbo].[DetallePrestamo] ",
                                                           "           ([idPrestamo]           ",
                                                           "           ,[idEjemplar]          ",
                                                           "           ,[idLibro]      ",
                                                           "           ,[fechaDevolucion]             ",
                                                           "           ,[borrado])             ",
                                                           "     VALUES                        ",
                                                           "           (@idPrestamo            ",
                                                           "           ,@idEjemplar           ",
                                                           "           ,@idLibro      ",
                                                           "           ,@fechaDevolucion              ",
                                                           "           ,@borrado)               ");

                       var paramDetalle = new Dictionary<string, object>();
                       paramDetalle.Add("idPrestamo", prestamo.IdPrestamo);
                       paramDetalle.Add("idEjemplar", itemPrestamo.IdEjemplar);
                       paramDetalle.Add("idLibro", itemPrestamo.IdLibro);
                       paramDetalle.Add("fechaDevolucion", itemPrestamo.FechaDevolucion);
                       paramDetalle.Add("borrado", false);

                       DBConexion.GetDBConexion().executeTransactionConParametros(sqlDetalle, paramDetalle);//

                   }
               }
              // dm.Commit();
           }
           catch (Exception ex)
           {
               //dm.Rollback();
               throw ex;
           }
           finally
           {
                // Cierra la conexión 
                //dm.Close();
                DBConexion.GetDBConexion().CloseConnection();
           }
           return true;
       }

    }

}



















/*internal bool Create(Prestamo prestamo)
      {
          DBConexion dm = DBConexion.GetDBConexion();
          try
          {
              //dm.Open();
              dm.beginTransaction();

              string sql = string.Concat("INSERT INTO [dbo].[Prestamo] ",
                                          "           ([fechaPrestamo]   ",
                                          "           ,[fechaLimite]         ",
                                          "           ,[idSocio]         ",
                                          "           ,[idEstadoPrestamo]         ",
                                          "           ,[borrado])      ",
                                          "     VALUES                 ",
                                          "           (@fechaPrestamo   ",
                                          "           ,@fechaLimite     ",
                                          "           ,@idSocio     ",
                                          "           ,@idEstadoPrestamo     ",
                                          "           ,@borrado)       ");


              var parametros = new Dictionary<string, object>();
              parametros.Add("fechaPrestamo", prestamo.FechaPrestamo);
              parametros.Add("fechaLimite", prestamo.FechaLimite);
              parametros.Add("idSocio", prestamo.IdSocio);
              parametros.Add("idEstadoPrestamo", prestamo.IdEstadoPrestamo);
              parametros.Add("borrado", false);
              dm.ConsultaSQLConParametros(sql, parametros);

              var newId = dm.ConsultaSQLScalar(" SELECT @@IDENTITY"); //ver
              prestamo.IdPrestamo = Convert.ToInt32(newId);


              foreach (var itemPrestamo in prestamo.DetallePrestamo)
              {
                  if (itemPrestamo.ToString() != null)
                  {


                      string sqlDetalle = string.Concat(" INSERT INTO [dbo].[DetallePrestamo] ",
                                                          "           ([idPrestamo]           ",
                                                          "           ,[idEjemplar]          ",
                                                          "           ,[idLibro]      ",
                                                          "           ,[fechaDevolucion]             ",
                                                          "           ,[borrado])             ",
                                                          "     VALUES                        ",
                                                          "           (@idPrestamo            ",
                                                          "           ,@idEjemplar           ",
                                                          "           ,@idLibro      ",
                                                          "           ,@fechaDevolucion              ",
                                                          "           ,@borrado)               ");

                      var paramDetalle = new Dictionary<string, object>();
                      paramDetalle.Add("idPrestamo", prestamo.IdPrestamo);
                      paramDetalle.Add("idEjemplar", itemPrestamo.IdEjemplar);
                      paramDetalle.Add("idLibro", itemPrestamo.IdLibro);
                      paramDetalle.Add("fechaDevolucion", itemPrestamo.FechaDevolucion);
                      paramDetalle.Add("borrado", false);

                      dm.EjecutarSQLCONPARAMETROS(sqlDetalle, paramDetalle);//

                  }
              }


             // dm.Commit();

          }
          catch (Exception ex)
          {
              //dm.Rollback();
              throw ex;
          }
          finally
          {
              // Cierra la conexión 
              //dm.Close();
          }
          return true;
      }*/
