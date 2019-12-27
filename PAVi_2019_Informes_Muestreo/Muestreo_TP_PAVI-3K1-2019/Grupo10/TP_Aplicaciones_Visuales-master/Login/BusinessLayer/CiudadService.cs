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
    class CiudadService
    {
        private CiudadDAO oCiudadDAO;
        public CiudadService()
        {
            oCiudadDAO = new CiudadDAO();
        }
        public IList<Ciudad> obtenerTodos()
        {
            return oCiudadDAO.getAll();
        }
        public DataTable obtenerCiudades(string nombreProcedimiento)
        {
            return oCiudadDAO.excecuteStoreProcedure(nombreProcedimiento);

        }
        public Ciudad obtenerCiudadSinParametros(int id)
        {
            return oCiudadDAO.obtenerCiudadSinParametros(id);
        }

        public Ciudad obtenerCiudadConParametros(int id)
        {
            return oCiudadDAO.obtenerCiudadConParametros(id);
        }

        public DataTable obtenerCiudadConParametros(Dictionary<string, object> parametros)
        {
            return oCiudadDAO.obtenerCiudadConParametros(parametros);
        }

        public bool existeCiudad(Ciudad oCiudad)
        {
            IList<Ciudad> ciudades = new List<Ciudad>();
            ciudades = oCiudadDAO.getAll();
            foreach (Ciudad a in ciudades)
            {
                if (oCiudad.Equals(a))
                {
                    return true;
                }
            }
            return false;

        }

        public int obtenerUltimoId()
        {
            return Convert.ToInt32(oCiudadDAO.ObtenerUltimo("idCiudad", "Ciudad"));
        }

        public int obtenerProximoId()
        {
            int idUltimo = obtenerUltimoId();
            return idUltimo++;
        }

        //Metodos que llaman a las operaciones CRUD
        //Cada uno de estos métodos llama a la correspondiente operacion crud
        // y retorna un bool, dependiendo si se realizo con exito la insercion/actualizacion/eliminacion


        public bool agregarCiudad(Ciudad oCiudad)
        {
            return oCiudadDAO.insert(oCiudad);
        }
        public bool actualizarCiudad(Ciudad oCiudad)
        {
            return oCiudadDAO.update(oCiudad);
        }
        public bool eliminarCiudad(Ciudad oCiudad)
        {
            return oCiudadDAO.logicalDelete(oCiudad);
        }
        public bool eliminarCiudad(int id)
        {
            return oCiudadDAO.logicalDelete(id);
        }
       


    }
}
