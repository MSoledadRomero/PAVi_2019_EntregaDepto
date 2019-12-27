using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Aplicaciones_Visuales.Entities
{
    class Socio
    {
        private int idSocio;
        private int idTipoDoc;
        private int idBarrio;
        private int numeroDocumento;
        private string nombre;
        private string apellido;
        private string mail;
        private int telefono;
        private string calle;
        private int nro;

        public int IdSocio { get => idSocio; set => idSocio = value; }
        public int IdTipoDoc { get => idTipoDoc; set => idTipoDoc = value; }
        public int IdBarrio { get => idBarrio; set => idBarrio = value; }       
        public int NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Nro { get => nro; set => nro = value; }

        public override string ToString()
        {
            return "Id: " + Convert.ToString(idSocio) + " Nombre: " + Nombre + " Apellido: " + Apellido + " Documento: " + Convert.ToString(NumeroDocumento) + " Mail: " + Mail + " Telefono: " +Convert.ToString( Telefono) + " Direccion: " + Calle + " " + Convert.ToString(Nro);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Socio))
            {
                Socio oSocio = (Socio)obj;
                if (oSocio.IdTipoDoc == this.IdTipoDoc && oSocio.NumeroDocumento == this.NumeroDocumento && oSocio.Nombre == this.Nombre && oSocio.Apellido == this.Apellido)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
