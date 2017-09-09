using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Examen.Entidades
{
    public class RespuestaExamenAlumno
    {
        public int SecuenciaRespuesta { get; private set; }
        public int SecuenciaExamenDetalle { get; set; }
        public ExamenDetalle PreguntaRealizada { get; set; }
        public int IdentificadorOpcion { get; set; }
        public OpcionPregunta Respuesta { get; set; }
        public bool EsCorrecto { get; private set; }
        public int NumeroSecuenciaExamenUsuario { get; set; }
        public virtual ResolucionExamen ExamenResuelto { get; set; }

        //public void ValidarRespuesta()
        //{
        //    VerificarRespuesta = true;

        //}
        //public static RespuestaExamenAlumno RegistrarRespuesta(int ainCodigoExamenAlumno, string astRespuesta, bool aboVerificarRespuesta)
        //{
        //    return new RespuestaExamenAlumno()
        //    {
        //        CodigoExamenAlumno = ainCodigoExamenAlumno,
        //        RespuestaExamenAl = astRespuesta,
        //        VerificarRespuesta = aboVerificarRespuesta
        //    };
        //}
    }
}
