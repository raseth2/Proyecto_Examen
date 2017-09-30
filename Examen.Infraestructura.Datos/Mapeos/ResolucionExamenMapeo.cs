using Proyecto_Examen.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructura.Datos.Mapeos
{
   
    public class ResolucionExamenMapeo : EntityTypeConfiguration<ResolucionExamen>
    {
        public ResolucionExamenMapeo()
        {
            ToTable("ResolucionExamen");
            //HasKey(k => k.id);
            Property(p => p.FechaHoraResolucion).HasColumnName("FechaHora_Resolucion").IsRequired();
            //Property(p => p.ExamenResuelto).HasColumnName("Examen_Resuelto").IsRequired();
            Property(p => p.IdentificadorExamen).HasColumnName("Identificador_Examen").IsRequired();
            Property(p => p.IDUsuario).HasColumnName("ID_Usuario").IsRequired();
            Property(p => p.NotaAlumno).HasColumnName("Nota_Alumno").IsRequired();
            Property(p => p.NumeroSecuenciaExamenUsuario).HasColumnName("Numero_Secuencia_ExamenUsuario").IsRequired();


            HasRequired(m => m.Respuestas).WithMany().HasForeignKey(f => f.NumeroSecuenciaExamenUsuario);
            HasRequired(m => m.Examen).WithMany().HasForeignKey(f => f.IdentificadorExamen);
            HasRequired(m => m.Usuario).WithMany().HasForeignKey(f => f.IDUsuario);



        }
    }
}
