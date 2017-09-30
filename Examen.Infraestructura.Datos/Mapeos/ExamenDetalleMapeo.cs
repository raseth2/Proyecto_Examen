using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_Examen.Entidades;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructura.Datos.Mapeos
{
  
    public class ExamenDetalleMapeo : EntityTypeConfiguration<ExamenDetalle>
    {
        public ExamenDetalleMapeo()
        {
            ToTable("ExamenDetalle");
           // HasKey(k => k.IdentificadorPregunta);
            Property(p => p.IdentificadorExamen).HasColumnName("Identificador_Examen").IsRequired();
            Property(p => p.IdentificadorPregunta).HasColumnName("Identificador_Pregunta").IsRequired();

            HasRequired(m => m.Examen).WithMany().HasForeignKey(f => f.IdentificadorExamen);
            HasRequired(m => m.Pregunta).WithMany().HasForeignKey(f => f.IdentificadorPregunta);


        }
    }
}
