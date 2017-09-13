using System;
using System.Collections.Generic;

namespace Proyecto_Examen.Entidades
{
    public class Examen
    {
        public int IdentificadorExamen { set; get; }
        public string NombreExamen { set; get; }
        public DateTime FechaCreacion { set; get; }
        public string Indicaciones { set; get; }
        public DateTime FechaInicioExamen { set; get; }
        public DateTime FechaFinalExamen { set; get; }
        public byte EstadoExamen { get; set; }
        public int IDUsuario { get; set; }
        public virtual Usuario Propietario { get; set; }
        public ICollection<ExamenDetalle> Preguntas { get; set; }
      

        public static Examen CrearExamen(int ainIndentificadorExamen, string ainNombreExamen)
        {
            return new Examen()
            {
                IdentificadorExamen = ainIndentificadorExamen,
                NombreExamen = ainNombreExamen,
                
            };
        }
        public static Examen EliminarExamen(int ainIndentificadorExamen)
        {
            return new Examen()
            {
                IdentificadorExamen = ainIndentificadorExamen
            };
        }
        public static Examen ModificarExamen(int idExamen, string nombreExamen, DateTime fechaCreacion, string indicaciones, DateTime fechaInicioExamen, DateTime fechaFinalExamen, byte estadoExamen, int idUsuario)
        {
            return new Examen()
            {
                IdentificadorExamen=idExamen,
                NombreExamen=nombreExamen,
                FechaCreacion=fechaCreacion,
                Indicaciones=indicaciones,
                FechaInicioExamen=fechaInicioExamen,
                FechaFinalExamen=fechaFinalExamen,
                EstadoExamen=estadoExamen,
                IDUsuario = idUsuario
                       
            };
        }

    }
}
