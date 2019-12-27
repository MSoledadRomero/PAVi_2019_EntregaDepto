using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.DataAccess;
using TP_Aplicaciones_Visuales.Entities;
using System.Data;




namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    class CompraService
    {
        private CompraDAO oCompraDAO;

        public CompraService()
        {
            oCompraDAO = new CompraDAO();
        }
        public void update(Compra oCompra)
        {
            oCompraDAO.update(oCompra);
        }
        public IList<Compra> obtenerTodos()
        {
            return oCompraDAO.getAll();
        }

        public DataTable obtenerTodosPorTabla()
        {
            return oCompraDAO.getAllInTable();
        }

        public int ObtenerUltimoId()
        {
            int id;
            if(!Int32.TryParse(oCompraDAO.ObtenerUltimo("idCompra", "Compra"),out id))
            {
                return 0;
            }
            return id;
            //return Convert.ToInt32((oCompraDAO.ObtenerUltimo("idCompra", "Compra"))); //Convierto a int el id 

        }

        public int ObtenerProximoId()
        {
            int idProx = ObtenerUltimoId();
            return idProx++;
        }

        public bool existeCompra(Compra oCompra)
        {
            IList<Compra> compras = new List<Compra>();
            compras = oCompraDAO.getAll();
            foreach (Compra c in compras)
            {
                if (oCompra.Equals(c))
                {
                    return true;
                }
            }
            return false;

        }

        public IList<Compra> obtenerCompraConParametros(Dictionary<string, object> parametros)
        {
            return oCompraDAO.obtenerCompraConParametros(parametros);
        }

   

        public Compra obtenerCompraSinParametros(int id)
        {
            return oCompraDAO.obtenerCompraSinParametros(id);
        }

  
        public bool insert(Compra oCompra)
        {
            return oCompraDAO.Lastinsert(oCompra);
        }

        public bool darDeBajaCompra(Compra oCompra)
        {
            return oCompraDAO.logicalDelete(oCompra);
        }




    }
}
