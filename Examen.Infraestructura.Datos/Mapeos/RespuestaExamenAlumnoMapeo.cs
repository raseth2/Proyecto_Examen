using Proyecto_Examen.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructura.Datos.Mapeos
{
   
    public class RespuestaExamenAlumnoMapeo : EntityTypeConfiguration<RespuestaExamenAlumno>
    {
        public RespuestaExamenAlumnoMapeo()
        {
            ToTable("RespuestaExamenAlumno");
            //HasKey(k => k.id);
            Property(p => p.EsCorrecto).HasColumnName("Es_Correcto").IsRequired();
            //Property(p => p.ExamenResuelto).HasColumnName("Examen_Resuelto").IsRequired();
            Property(p => p.IdentificadorOpcion).HasColumnName("Identificador_Opcion").IsRequired();
            Property(p => p.NumeroSecuenciaExamenUsuario).HasColumnName("Numero_Secuencia_Examen_Usuario").IsRequired();
            Property(p => p.SecuenciaExamenDetalle).HasColumnName("Secuencia_Examen_Detalle").IsRequired();
            Property(p => p.SecuenciaRespuesta).HasColumnName("Secuencia_Respuesta").IsRequired();
           

            HasRequired(m => m.PreguntaRealizada).WithMany().HasForeignKey(f => f.SecuenciaExamenDetalle);
            HasRequired(m => m.Respuesta).WithMany().HasForeignKey(f => f.EsCorrecto);



        }
    }
}
