using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Examen.Entidades
{
    public class ExamenDetalle
    {
        public int SecuenciaExamenDetalle { get; set; }
        public int IdentificadorExamen { get; set; }
        public virtual Examen Examen { get; set; }
        public int IdentificadorPregunta { get; set; }
        public virtual Pregunta Pregunta { get; set; }
        //hola que fue de elisban

        public static ExamenDetalle CrearExamenDetalle(int secuenciaExamenDetalle, int identificadorExamen, int identificadorPregunta)
        {
            return new ExamenDetalle()
            {
                SecuenciaExamenDetalle = secuenciaExamenDetalle,
                IdentificadorExamen = identificadorExamen,
                IdentificadorPregunta = identificadorPregunta
            };
        }
        public static ExamenDetalle EliminarExamenDetalle(int identificadorExamen)
        {
            return new ExamenDetalle()
            {
                IdentificadorExamen = identificadorExamen
            };
        }
        public static ExamenDetalle ModificarExamenDetalle(int secuenciaExamenDetalle, int identificadorExamen, int identificadorPregunta)
        {
            return new ExamenDetalle()
            {
                SecuenciaExamenDetalle = secuenciaExamenDetalle,
                IdentificadorPregunta = identificadorPregunta
            };
        }

    }
}
