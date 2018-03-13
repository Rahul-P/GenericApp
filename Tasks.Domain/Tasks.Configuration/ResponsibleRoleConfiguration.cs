
namespace Tasks.Domain.Tasks.Configuration
{
    using DomainCommons;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ResponsibleRoleConfiguration : BaseDomainConfiguration<ResponsibleRole>
    {
        public override void Configure(EntityTypeBuilder<ResponsibleRole> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(500);

        }
    }
}
