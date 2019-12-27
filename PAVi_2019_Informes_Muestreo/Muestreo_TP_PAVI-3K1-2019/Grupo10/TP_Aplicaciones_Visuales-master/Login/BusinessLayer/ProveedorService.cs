using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.DataAccess;
using TP_Aplicaciones_Visuales.Entities;
namespace TP_Aplicaciones_Visuales.BusinessLayer
{
    class ProveedorService
    {
        ProveedorDAO oProveedorDAO = new ProveedorDAO();
        

        public IList<Proveedor> ObtenerTodos()
        {
            return oProveedorDAO.getAll();
        }
        public DataTable obtenerTodosPorTabla()
        {
            return oProveedorDAO.getAllInTable();
        }

        public DataTable obtenerProveedores(string nombreProcedimiento)
        {
            return oProveedorDAO.excecuteStoreProcedure(nombreProcedimiento);
        }

        public Proveedor obtenerProveedorSinParametros(int id)
        {
            return oProveedorDAO.obtenerProveedorSinParametros(id);
        }

        public DataTable obtenerProveedoresConParametros(Dictionary<String, Object> parametros)
        {
            return oProveedorDAO.obtenerProveedoresConParametros(parametros);
        }

        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oProveedorDAO.ObtenerUltimo("idProveedor", "Proveedor"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }
        




        public bool existeProveedor(Proveedor oProveedor)
        {
            IList<Proveedor> proveedores = new List<Proveedor>();
            proveedores = oProveedorDAO.getAll();
            foreach (Proveedor a in proveedores)
            {
                if (oProveedor.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }







        public bool insertarProveedor(Proveedor proveedor)
        {
            return oProveedorDAO.insert(proveedor);
        }
        public bool actualizarProveedor(Proveedor proveedor)
        {
            return oProveedorDAO.update(proveedor);
        }
        public bool darDeBajaProveedor(int id)
        {
            return oProveedorDAO.logicalDelete(id);
        }
        public bool darDeBajaProveedor(Proveedor oProveedor)
        {
            return oProveedorDAO.logicalDelete(oProveedor);
        }
        /*public IList<Proveedor> ConsultarConFiltrosSinParametros(String condiciones)
        {
            return oProveedorDAO.GetByFiltersSinParametros(condiciones);
        }*/
    }
}
