namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.AssetGroupConfigurations;

public class GroupEntityTypeConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
       .IsRequired()
       .HasMaxLength(200);

        builder.HasIndex(x => x.Title)
       .IsUnique();

        builder.HasMany(x => x.Categories)
            .WithOne(x => x.Group)
            .HasForeignKey(x => x.GroupId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("Groups");
    }
}
