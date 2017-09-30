using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using Proyecto_Examen.Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructura.Datos.Mapeos
{
    public class PreguntaMapeo : EntityTypeConfiguration<Pregunta>
    {
        public PreguntaMapeo()
        {
            ToTable("Pregunta");
            HasKey(k => k.IdentificadorPregunta);
            Property(p => p.IDUsuario).HasColumnName("Id_usuario").IsRequired();
            Property(p => p.DestallePregunta).HasColumnName("Detalle_Pregunta").IsRequired().HasMaxLength(50);

            HasRequired(m => m.Propietario).WithMany().HasForeignKey(f => f.IDUsuario);
            HasRequired(m => m.Opciones).WithMany().HasForeignKey(f => f.IdentificadorPregunta);


        }
    }
}
