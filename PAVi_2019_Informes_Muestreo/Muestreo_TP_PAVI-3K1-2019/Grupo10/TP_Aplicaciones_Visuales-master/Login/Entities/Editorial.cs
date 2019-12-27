using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class Editorial
    {
        private int idEditorial;
        private string nombreEditorial;

        public int IdEditorial { get => idEditorial; set => idEditorial = value; }
        public string NombreEditorial { get => nombreEditorial; set => nombreEditorial = value; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Editorial))
            {
                Editorial oEditorial = (Editorial)obj;
                if (oEditorial.NombreEditorial == this.NombreEditorial)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string e = string.Concat("Id: ",
                                    this.idEditorial.ToString(),
                                    "Nombre:",
                                    this.NombreEditorial);
            return e;
        }

    }
}
