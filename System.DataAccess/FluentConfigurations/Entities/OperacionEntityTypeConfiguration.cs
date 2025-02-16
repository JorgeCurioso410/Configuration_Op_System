using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Dominio.Entities;
using System.DataAccess.FluentConfigurations.Common;

namespace System.DataAccess.FluentConfigurations.Entities
{
    public class OperacionEntityTypeConfiguration : EntityTypeConfigurationBase<Operacion>
    {
        public override void Configure(EntityTypeBuilder<Operacion> builder)

        {
            ///Relacion a tomar de cada aspecto con su tabla correspondient
            builder.ToTable("Operaciones");
            builder.Ignore(x => x.FaseList);
            builder.Ignore(x => x.RecetaList);
            base.Configure(builder);

        }

    }
}
