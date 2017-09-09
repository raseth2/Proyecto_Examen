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
        //hola 

    }
}
