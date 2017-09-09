using System;

namespace Proyecto_Examen.Entidades
{
    public class Usuario
    {
        //public int DNI { set; get; }
        public int IDUsuario { set; get; }
        public string CodigoUsuario { get; set; }
        public string NombreUsuario { set; get; }
        public string ClaveUsuario { get; set; }
        public byte CodigoTipoUsuario { get; set; }
        public virtual TipoUsuario TipoDeUsuario { get; set; }
        //public String ApellidoPaterno { set; get; }
        //public string ApellidoMaterno { set; get; }
        //public int telefono { set; get; }

        public static Usuario CrearNuevoUsuario(int idUsuario, string codigoUsuario, string nombreUsuario, string claveUsuario, byte codigoTipoUsuario)
        {
            return new Usuario()
            {
                IDUsuario = idUsuario,
                CodigoUsuario = codigoUsuario,
                NombreUsuario = nombreUsuario,
                ClaveUsuario = claveUsuario,
                CodigoTipoUsuario = codigoTipoUsuario,

            };
        }

    }
}
