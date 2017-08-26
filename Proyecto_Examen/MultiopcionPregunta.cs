using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Examen
{
    class MultiopcionPregunta
    {
        public int CodigoOpcion { get; set; }
        public int CodigoPregunta { get; set; }
        public string DetalleOpcion { get; set; }
        public virtual PreguntaExamen preguntaExamen { get; private set; }
        public static MultiopcionPregunta CrearOpcionPregunta(int ainCodigoPregunta, int ainCodigoOpcion, string astDetalleOpcion)
        {
            return new MultiopcionPregunta()
            {
                CodigoPregunta = ainCodigoPregunta,
                CodigoOpcion = ainCodigoOpcion,
                DetalleOpcion = astDetalleOpcion
            };
        }
        public static MultiopcionPregunta EliminarOpcionPregunta(int ainCodigoOpcion)
        {
            return new MultiopcionPregunta()
            {
                CodigoOpcion = ainCodigoOpcion
            };
        }
        public static MultiopcionPregunta ModificarOpcionPregunta(int ainCodigoPregunta, int ainCodigoOpcion, string astDetalleOpcion)
        {
            return new MultiopcionPregunta()
            {
                CodigoPregunta = ainCodigoPregunta,
                CodigoOpcion = ainCodigoOpcion,
                DetalleOpcion = astDetalleOpcion
            };
        }
    }
}
