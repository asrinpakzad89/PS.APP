namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.ToolTypeConfigurations;

public class ToolTypeEntityTypeConfiguration : IEntityTypeConfiguration<ToolType>
{
    public void Configure(EntityTypeBuilder<ToolType> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
        .IsRequired()
        .HasMaxLength(200);

        builder.HasIndex(x => x.Title)
         .IsUnique();


        builder.HasMany(x => x.Tools)
            .WithOne(x => x.ToolType)
            .HasForeignKey(x => x.ToolTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("ToolTypes");
    }
}