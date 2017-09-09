using Proyecto_Examen.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Examen.Infraestructura.Datos.Mapeos
{
    public class TipoUsuarioMapeo : EntityTypeConfiguration<TipoUsuario>
    {
        public TipoUsuarioMapeo()
        {
            ToTable("Tipo_Usuario");
            HasKey(k => k.CodigoTipoUsuario);
            Property(p => p.CodigoTipoUsuario).IsRequired();
            Property(p => p.DescripcionTipoUsuario).IsRequired().HasMaxLength(50);
        }
    }
}
