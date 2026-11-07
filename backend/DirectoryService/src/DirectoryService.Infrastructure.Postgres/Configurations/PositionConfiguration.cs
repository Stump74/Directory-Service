using DirectoryService.Domain.LengthLimit;
using DirectoryService.Domain.Positions;
using DirectoryService.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class PositionConfiguration : IEntityTypeConfiguration<Position>
{
    public void Configure(EntityTypeBuilder<Position> builder)
    {
        builder.ToTable("positions");

        builder.HasKey(p => p.Id).HasName("pk_positions");

        builder.Property(p => p.Id)
            .HasColumnName("id")
            .HasConversion(p => p.Value, id => PositionId.New(id));

        builder.Property(p => p.Name)
            .HasColumnName("name")
            .HasMaxLength(LengthLimits.MaxNameLength)
            .HasConversion(n => n.Value, value => Name.Create(value).Value);
    }
}