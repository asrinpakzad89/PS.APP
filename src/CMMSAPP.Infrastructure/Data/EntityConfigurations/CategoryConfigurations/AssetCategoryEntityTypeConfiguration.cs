namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.AssetCategoryConfigurations;

public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
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

        builder.HasOne(x => x.Group)
            .WithMany(x => x.Categories)
            .HasForeignKey(x => x.GroupId);


        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("Categories");
    }
}
