using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Examen.Entidades
{
    public class OpcionPregunta
    {
        public int IdentificadorOpcion { get; set; }
        public string DetalleOpcion { get; set; }
        public int IdentificadorPregunta { get; set; }
        public virtual Pregunta Pregunta { get; private set; }
        public bool EsCorrecta { get; set; }
        public static OpcionPregunta CrearOpcionPregunta(int ainCodigoPregunta, int ainCodigoOpcion, string astDetalleOpcion)
        {
            return new OpcionPregunta()
            {
                IdentificadorPregunta = ainCodigoPregunta,
                IdentificadorOpcion = ainCodigoOpcion,
                DetalleOpcion = astDetalleOpcion
            };
        }
        public static OpcionPregunta EliminarOpcionPregunta(int ainCodigoOpcion)
        {
            return new OpcionPregunta()
            {
                IdentificadorPregunta = ainCodigoOpcion
            };
        }
        public static OpcionPregunta ModificarOpcionPregunta(int ainCodigoPregunta, int ainCodigoOpcion, string astDetalleOpcion)
        {
            return new OpcionPregunta()
            {
                IdentificadorPregunta = ainCodigoPregunta,
                IdentificadorOpcion = ainCodigoOpcion,
                DetalleOpcion = astDetalleOpcion
            };
        }
    }
}
