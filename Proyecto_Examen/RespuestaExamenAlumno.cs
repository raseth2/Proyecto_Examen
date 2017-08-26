using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Examen
{
    class RespuestaExamenAlumno
    {
        public int CodigoExamenAlumno { get; private set; }
        public string RespuestaExamenAl { get; private set; }
        public bool VerificarRespuesta { get; private set; }
  
        public virtual ExamenAlumno examenAlumno { get; set; }


        public void ValidarRespuesta()
        {
            VerificarRespuesta = true;

        }
        public static RespuestaExamenAlumno RegistrarRespuesta(int ainCodigoExamenAlumno, string astRespuesta, bool aboVerificarRespuesta)
        {
            return new RespuestaExamenAlumno()
            {
                CodigoExamenAlumno = ainCodigoExamenAlumno,
                RespuestaExamenAl = astRespuesta,
                VerificarRespuesta = aboVerificarRespuesta
            };
        }
    }
}
