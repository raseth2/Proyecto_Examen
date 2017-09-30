using System;
using System.Collections.Generic;
using Proyecto_Examen.Entidades;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructura.Datos.Mapeos
{
    public class UsuarioMapero : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapero()
        {
            ToTable("Usuario");
            HasKey(k => k.IDUsuario);
            Property(p => p.ClaveUsuario).HasColumnName("Clave_Usuario").IsRequired();
            Property(p => p.CodigoTipoUsuario).HasColumnName("Codigo_Tipo_Usuario").IsRequired();
            Property(p => p.CodigoUsuario).HasColumnName("Codigo_Usuario").IsRequired().HasMaxLength(50);
            Property(p => p.NombreUsuario).HasColumnName("Nombre_Usuario").IsRequired().HasMaxLength(50);

            HasRequired(m => m.TipoDeUsuario).WithMany().HasForeignKey(f => f.CodigoTipoUsuario);

        }
    }
}
