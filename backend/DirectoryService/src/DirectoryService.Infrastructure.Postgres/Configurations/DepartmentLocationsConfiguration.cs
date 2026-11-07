using DirectoryService.Domain.Departments;
using DirectoryService.Domain.Locations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class DepartmentLocationsConfiguration : IEntityTypeConfiguration<DepartmentLocation>
{
    public void Configure(EntityTypeBuilder<DepartmentLocation> builder)
    {
        builder.ToTable("department_locations");

        builder.HasKey(dl => dl.Id).HasName("pk_department_locations");

        builder.Property(dl => dl.DepartmentId)
            .HasConversion(d => d.Value, id => DepartmentId.New(id));

        builder.Property(dl => dl.LocationId)
            .HasConversion(l => l.Value, id => LocationId.New(id));
    }
}