using DirectoryService.Domain.Departments;
using DirectoryService.Domain.Positions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class DepartmentPositionConfiguration: IEntityTypeConfiguration<DepartmentPosition>
{
    public void Configure(EntityTypeBuilder<DepartmentPosition> builder)
    {
        builder.ToTable("department_positions");

        builder.HasKey(dp => dp.Id).HasName("pk_department_positions");

        builder.Property(dp => dp.DepartmentId)
            .HasColumnName("department_id")
            .HasConversion(dp => dp.Value, id => DepartmentId.New(id));

        builder.Property(dp => dp.PositionId)
            .HasColumnName("position_id")
            .HasConversion(p => p.Value, id => PositionId.New(id));

        builder.Property(dp => dp.Id)
            .HasColumnName("id");

        builder.HasOne<Department>()
            .WithMany()
            .HasForeignKey(dp => dp.DepartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<Position>()
            .WithMany()
            .HasForeignKey(dp => dp.PositionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(dp => new { dp.DepartmentId, dp.PositionId }).IsUnique();
    }
}