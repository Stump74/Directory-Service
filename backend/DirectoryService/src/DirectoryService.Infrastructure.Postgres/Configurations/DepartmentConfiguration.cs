using System.Reflection.Metadata;
using CSharpFunctionalExtensions;
using DirectoryService.Domain.Departments;
using DirectoryService.Domain.LengthLimit;
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
            .HasColumnName("id")
            .HasConversion(d => d.Value, id => DepartmentId.New(id));

        builder.Property(d => d.Slug)
            .HasColumnName("slug")
            .HasMaxLength(LengthLimits.MinNameLength)
            .HasConversion(s => s.Value,
                value => Slug.Create(value).Value);

        builder.Property(d => d.Name)
            .HasColumnName("name")
            .HasMaxLength(LengthLimits.MaxNameLength)
            .HasConversion(n => n.Value,
                value => Name.Create(value).Value);

        builder.Property(d => d.ParentId)
            .HasColumnName("parent_id")
            .HasConversion(
                parentId => parentId == null ? (Guid?)null : parentId.Value,
                value => value.HasValue ? DepartmentId.New(value.Value) : null);

        builder.HasOne<Department>()
            .WithMany()
            .HasForeignKey(d => d.ParentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(d => d.Path)
            .HasColumnName("path")
            .HasMaxLength(LengthLimits.MinNameLength)
            .HasConversion(p => p.Value,
                value => Path.Create(value).Value);
    }
}