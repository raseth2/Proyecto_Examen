
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

        //metodos454
        ///546454
        ///
        public static Pregunta CrearPregunta(int idPregunta,string detallePregunta,int idUsuario)
        {
            return new Pregunta()
            {
                IdentificadorPregunta = idPregunta,
                DestallePregunta=detallePregunta,
                IDUsuario=idUsuario
            };
        }
        public static Pregunta ModificarPregunta(int idPregunta, string detallePregunta, int idUsuario)
        {
            return new Pregunta()
            {
                IdentificadorPregunta = idPregunta,
                DestallePregunta = detallePregunta,
                IDUsuario = idUsuario
            };
        }
        public static Pregunta EliminarPregunta(int idPregunta)
        {
            return new Pregunta()
            {
                IdentificadorPregunta = idPregunta
            };
        }

    }
}
