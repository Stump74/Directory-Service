using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments;
using DirectoryService.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Path = DirectoryService.Domain.Departments.Path;

namespace DirectoryService.Infrastructure.Postgres.Configurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("departments");

        builder.HasKey(d => d.Id).HasName("pk_departments");

        builder.Property(d => d.Id)
            .HasConversion(d => d.Value, id => DepartmentId.New(id));

        builder.Property(d => d.Slug).
            HasConversion(s => s.Value,
                value => Slug.Create(value).Value);

        builder.Property(d => d.Name)
            .HasConversion(n => n.Value,
                value => Name.Create(value).Value);

        builder.Property(d => d.ParentId)
            .HasConversion(
                parentId => parentId == null ? (Guid?)null : parentId.Value,
                value => value.HasValue ? DepartmentId.New(value.Value) : null);

        builder.HasOne<Department>()
            .WithMany()
            .HasForeignKey(d => d.ParentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(d => d.Path)
            .HasConversion(p => p.Value,
                value => Path.Create(value).Value);
    }
}