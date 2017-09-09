using Examen.Infraestructura.Datos.Mapeos;
using Proyecto_Examen.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructura.Datos
    //hola hola
    //prueba commit
{
    public class ExamenContexto : DbContext
    {
        public ExamenContexto() : base("")
        {
        }

        public IDbSet<TipoUsuario> TiposDeUsuarios { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new TipoUsuarioMapeo());
        }

    }
}
