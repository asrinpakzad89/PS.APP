using CMMSAPP.Domain.AggregatesModel.VisitAggregate;

namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.VisitConfigurations;

class VisitEntityTypeConfiguration : IEntityTypeConfiguration<Visit>
{
    public void Configure(EntityTypeBuilder<Visit> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
        .IsRequired()
        .HasMaxLength(200);

        builder.HasIndex(x => x.Title)
        .IsUnique();


        builder.Property(x => x.Code)
       .IsRequired()
       .HasMaxLength(50);

        builder.HasIndex(x => x.Code)
       .IsUnique();


        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("Visits");
    }
}