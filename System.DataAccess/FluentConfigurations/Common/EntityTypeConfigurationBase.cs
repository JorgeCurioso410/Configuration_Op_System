﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Dominio.Common;

namespace System.DataAccess.FluentConfigurations.Common
{
    public abstract class EntityTypeConfigurationBase<T> : IEntityTypeConfiguration<T> where T : Entity
    {

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

        }
    }
}
