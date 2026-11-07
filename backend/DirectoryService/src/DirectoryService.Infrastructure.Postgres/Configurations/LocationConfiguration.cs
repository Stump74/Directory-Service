using DirectoryService.Domain.Locations;
using DirectoryService.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("locations");

        builder.HasKey(l => l.Id).HasName("pk_locations");

        builder.Property(l => l.Id)
            .HasConversion(l => l.Value, id => LocationId.New(id));

        builder.Property(l => l.Name)
            .HasConversion(n => n.Value,
                value => Name.Create(value).Value);

        builder.ComplexProperty(l => l.Address, address =>
        {
            address.Property(a => a.Street).HasColumnName("street");

            address.Property(a => a.City).HasColumnName("city");

            address.Property(a => a.Country).HasColumnName("country");

            address.Property(a => a.House).HasColumnName("house");
        });
    }
}