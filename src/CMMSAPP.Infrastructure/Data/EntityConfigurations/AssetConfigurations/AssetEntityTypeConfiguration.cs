namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.AssetConfigurations;

public class EquipmentEntityTypeConfiguration : IEntityTypeConfiguration<Asset>
{
    public void Configure(EntityTypeBuilder<Asset> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedNever();

        builder.Property(e => e.Title)
            .IsRequired()
            .HasMaxLength(200);

        builder.HasIndex(x => x.Title)
       .IsUnique();

        builder.Property(e => e.Code)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(x => x.Code)
       .IsUnique();

        builder.Property(x => x.IsAssembly).IsRequired();


        builder.HasOne(x => x.AssetCategory)
        .WithMany(x=>x.Assets)
        .HasForeignKey(x => x.CategoryId);

        builder.HasOne(x => x.Parent)
        .WithMany(x => x.Children)
        .HasForeignKey(x => x.ParentId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.AssetIdentity)
        .WithMany()
        .HasForeignKey(x => x.AssetIdentityId)
        .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("Assets");
    }
}

