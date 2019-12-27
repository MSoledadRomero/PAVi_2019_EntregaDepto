using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Aplicaciones_Visuales.Entities;

namespace TP_Aplicaciones_Visuales.Entities
{
    class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string contraseña;
        private string estado;
        private Perfil perfil;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Estado { get => estado; set => estado = value; }
        public Perfil Perfil { get => perfil; set => perfil = value; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Usuario))
            {
                Usuario oUsuario = (Usuario)obj;
                if (oUsuario.NombreUsuario == this.NombreUsuario)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
