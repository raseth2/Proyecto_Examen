using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Examen
{
    class ExamenAlumno
    {
        public int CodigoExamenAlumno { get; private set; }

        public int CodigoExamen { get; set; }
        public int NotaAlumno { get; set; }
        public string CodigoPersona { get; set; }

        public ExamenAlumno BuscarExamenAlumno(int aiCodigoalumno)
        {
            return this;
        }

        public static ExamenAlumno RendirExamenAlumno(int ainCodigoExamenAlumno, int ainCodigoExamen)
        {
            return new ExamenAlumno()
            {
                CodigoExamenAlumno = ainCodigoExamenAlumno,
                CodigoExamen = ainCodigoExamen


            };
        }
        public static ExamenAlumno VisualizarExamenAlumno(int ainCodigoExamenAlumno)
        {
            return new ExamenAlumno()
            {
                CodigoExamenAlumno = ainCodigoExamenAlumno

            };
        }

    }
}
