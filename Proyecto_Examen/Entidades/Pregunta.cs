
using System.Collections.Generic;

namespace Proyecto_Examen.Entidades
{
    public class Pregunta
    {
        public int IdentificadorPregunta { get; set; }
        public string DestallePregunta { get; set; }
        //public int IdentificadorExamen { get; set; }
        //public virtual Examen Examen { get; set; }
        //public decimal PuntajePregunta { get; set; }
        public virtual ICollection<OpcionPregunta> Opciones { get; set; }
        public int IDUsuario { get; set; }
        public virtual Usuario Propietario { get; set; }

        //metodos
    }
}
