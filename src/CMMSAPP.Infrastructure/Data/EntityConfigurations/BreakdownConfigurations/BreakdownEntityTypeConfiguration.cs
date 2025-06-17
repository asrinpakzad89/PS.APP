using CMMSAPP.Domain.AggregatesModel.BreakdownAggregate;

namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.BreakdownConfigurations;

public class BreakdownEntityTypeConfiguration : IEntityTypeConfiguration<Breakdown>
{
    public void Configure(EntityTypeBuilder<Breakdown> builder)
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
        builder.ToTable("Breakdowns");
    }
}
