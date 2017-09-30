using Proyecto_Examen.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructura.Datos.Mapeos
{
   
    public class OpcionPreguntaMapeo : EntityTypeConfiguration<OpcionPregunta>
    {
        public OpcionPreguntaMapeo()
        {
            ToTable("OpcionPregunta");
            HasKey(k => k.IdentificadorOpcion);
            Property(p => p.IdentificadorOpcion).HasColumnName("Identificador_Opcion").IsRequired();
            Property(p => p.IdentificadorPregunta).HasColumnName("Identificador_Pregunta").IsRequired();
            Property(p => p.DetalleOpcion).HasColumnName("Detalle_Opcion").IsRequired().HasMaxLength(50);
            Property(p => p.EsCorrecta).HasColumnName("Es_Correcta").IsRequired();

            HasRequired(m => m.Pregunta).WithMany().HasForeignKey(f => f.IdentificadorPregunta);


        }
    }
}
