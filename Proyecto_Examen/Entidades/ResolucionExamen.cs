using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Examen.Entidades
{
    public class ResolucionExamen
    {
        public int NumeroSecuenciaExamenUsuario { get; private set; }
        public int IdentificadorExamen { get; set; }
        public virtual Examen Examen { get; set; }
        public int IDUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public decimal NotaAlumno { get; set; }
        public DateTime FechaHoraResolucion { get; set; }

        public ICollection<RespuestaExamenAlumno> Respuestas { get; set; }
        //Hola a todos

        //public ExamenAlumno BuscarExamenAlumno(int aiCodigoalumno)
        //{
        //    return this;
        //}

        //public static ExamenAlumno RendirExamenAlumno(int ainCodigoExamenAlumno, int ainCodigoExamen)
        //{
        //    return new ExamenAlumno()
        //    {
        //        CodigoExamenAlumno = ainCodigoExamenAlumno,
        //        CodigoExamen = ainCodigoExamen


        //    };
        //}
        //public static ExamenAlumno VisualizarExamenAlumno(int ainCodigoExamenAlumno)
        //{
        //    return new ExamenAlumno()
        //    {
        //        CodigoExamenAlumno = ainCodigoExamenAlumno

        //    };
        //}

    }
}
