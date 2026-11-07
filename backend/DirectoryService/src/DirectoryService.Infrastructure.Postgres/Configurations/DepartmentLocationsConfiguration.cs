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

        builder.Property(dl => dl.Id)
            .HasColumnName("id");

        builder.Property(dl => dl.DepartmentId)
            .HasColumnName("department_id")
            .HasConversion(d => d.Value, id => DepartmentId.New(id));

        builder.Property(dl => dl.LocationId)
            .HasColumnName("location_id")
            .HasConversion(l => l.Value, id => LocationId.New(id));

        builder.HasOne<Department>()
            .WithMany()
            .HasForeignKey(dl => dl.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<Location>()
            .WithMany()
            .HasForeignKey(dl => dl.LocationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(dl => new { dl.DepartmentId, dl.LocationId }).IsUnique();

        builder.Ignore(dl => dl.IsPrimary);
    }
}