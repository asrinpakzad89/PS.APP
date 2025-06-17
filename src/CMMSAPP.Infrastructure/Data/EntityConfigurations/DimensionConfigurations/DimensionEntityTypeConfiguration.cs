namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.DimensionConfigurations;

public class DimensionEntityTypeConfiguration : IEntityTypeConfiguration<Dimension>
{
    public void Configure(EntityTypeBuilder<Dimension> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
         .IsRequired()
         .HasMaxLength(200);

        builder.HasIndex(x => x.Title)
         .IsUnique();

        builder.Property(x => x.Unit)
         .IsRequired()
         .HasMaxLength(50);

        builder.HasMany(x=>x.AssetDimensions)
            .WithOne(x=>x.Dimension)
            .HasForeignKey(x=>x.DimensionId)
            .OnDelete(DeleteBehavior.Restrict);


        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("Dimensions");
    }
}
