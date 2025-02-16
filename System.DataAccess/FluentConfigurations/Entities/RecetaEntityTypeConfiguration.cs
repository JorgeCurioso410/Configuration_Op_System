using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Dominio.Entities;
using System.DataAccess.FluentConfigurations.Common;

namespace System.DataAccess.FluentConfigurations.Entities
{
    public class RecetaEntityTypeConfiguration : EntityTypeConfigurationBase<Receta>

    {
        public override void Configure(EntityTypeBuilder<Receta> builder)
        {
            ///Relacion a tomar de cada aspecto con su tabla correspondient
            builder.ToTable("Recetas");
            builder.Ignore(x => x.FaseList);
            builder.Ignore(x => x.OperacionList);
            base.Configure(builder);
        }
    }
}
