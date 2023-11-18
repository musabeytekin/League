using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AdessoWorldLeague.API.Configurations;

public class DrawResultEntityTypeConfiguration : IEntityTypeConfiguration<DrawResult>
{
    public void Configure(EntityTypeBuilder<DrawResult> builder)
    {
        builder.ToTable("DrawResults");
        builder.HasKey(l => l.Id);
        builder.Property(l => l.Id).ValueGeneratedOnAdd();

        builder.OwnsMany(l => l.Groups).WithOwner();
    }
}
