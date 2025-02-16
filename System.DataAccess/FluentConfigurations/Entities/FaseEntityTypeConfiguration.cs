using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Dominio.Entities;
using System.DataAccess.FluentConfigurations.Common;

namespace System.DataAccess.FluentConfigurations.Entities
{
    public class FaseEntityTypeConfiguration : EntityTypeConfigurationBase<Fase>
    {
        public override void Configure(EntityTypeBuilder<Fase> builder)
        {
            ///Relacion a tomar de cada aspecto con su tabla correspondiente 
            builder.ToTable("Fases");
            builder.Ignore(f => f.RecetaList);
            builder.HasKey(f => f.OperacionList);
            base.Configure(builder);
        }
    }
}
