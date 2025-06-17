namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.StandardPartsConfigurations;

public class StandardPartsEntityTypeConfiguration : IEntityTypeConfiguration<StandardPart>
{
    public void Configure(EntityTypeBuilder<StandardPart> builder)
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


        builder.Property(x => x.UnitOfMeasure)
                .IsRequired()
                .HasMaxLength(50);


        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("StandardParts");
    }
}
