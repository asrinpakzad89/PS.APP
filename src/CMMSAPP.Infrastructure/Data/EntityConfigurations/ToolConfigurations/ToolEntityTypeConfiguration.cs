namespace CMMSAPP.Infrastructure.Data.EntityConfigurations.ToolConfigurations;

public class ToolEntityTypeConfiguration : IEntityTypeConfiguration<Tool>
{
    public void Configure(EntityTypeBuilder<Tool> builder)
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

        builder.HasOne(x => x.ToolType)
            .WithMany(x => x.Tools)
            .HasForeignKey(x => x.ToolTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasQueryFilter(x => !x.IsDelete);
        builder.ToTable("Tools");
    }
}