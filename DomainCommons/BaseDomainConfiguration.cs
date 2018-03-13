
namespace DomainCommons
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BaseDomainConfiguration<TBaseDomainClass> 
        : IEntityTypeConfiguration<TBaseDomainClass> where TBaseDomainClass : BaseDomain, new()
    {
        public virtual void Configure(EntityTypeBuilder<TBaseDomainClass> builder)
        {        
            builder.Ignore(p => p.IsDirty);

            builder.Property(p => p.Rowversion).IsRowVersion().ValueGeneratedOnAddOrUpdate().IsRequired();

            builder.Property(p => p.CreatedOn).ValueGeneratedOnAdd().IsRequired();
            builder.Property(p => p.LastModifiedOn).ValueGeneratedOnAddOrUpdate().IsRequired();

            builder.Property(p => p.CreatedBy).IsRequired().HasMaxLength(200);
            builder.Property(p => p.LastModifiedBy).IsRequired().HasMaxLength(200);
        }
    }
}
