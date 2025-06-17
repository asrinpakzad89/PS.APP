namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.LevelConfigurations;

public class LevelEntityTypeConfiguration : IEntityTypeConfiguration<Level>
{
    public void Configure(EntityTypeBuilder<Level> builder)
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


        builder.HasOne(x => x.Parent)
            .WithMany(x => x.Children)
            .HasForeignKey(x => x.ParentId)
            .OnDelete(DeleteBehavior.Restrict);


        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("InstalledAssetCodings");
    }
}
