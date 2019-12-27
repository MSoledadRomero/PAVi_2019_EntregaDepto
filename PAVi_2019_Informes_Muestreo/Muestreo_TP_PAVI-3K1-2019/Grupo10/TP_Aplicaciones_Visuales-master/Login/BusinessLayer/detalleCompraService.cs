using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.DataAccess;
using TP_Aplicaciones_Visuales.Entities;
namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    public class DetalleCompraService
    {
        private DetalleCompraDAO oDetalleCompraDAO;
        public DetalleCompraService()
        {
            oDetalleCompraDAO = new DetalleCompraDAO();
        }
        public void deleteForId(int id)
        {
            oDetalleCompraDAO.delete(id);
        }

        public void insert(DetalleCompra DC)
        {
            oDetalleCompraDAO.insert(DC);
        }
        public void update(DetalleCompra DC)
        {
            oDetalleCompraDAO.update(DC);
        }
        public IList<DetalleCompra> ConsultarPorIdCompra(int idCompra)
        {
            return oDetalleCompraDAO.GetByIdCompra(idCompra);
        }
    }
}