using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Departments;

public sealed class Department
{
    private Department( Slug slug, Name name, Path path, DepartmentId? parentId, DateTime? createdAt, DateTime? updatedAt)
    {
        Id = DepartmentId.New(id: null);
        Slug = slug;
        ParentId = parentId;
        Name = name;
        Path = path;
        CreatedAt = createdAt ?? DateTime.UtcNow;
        UpdatedAt = updatedAt ?? DateTime.UtcNow;
    }
    // For EF Core
    private Department()
    {
        Id = null!;
        Slug = null!;
        Name = null!;
        Path = null!;
    }
    public DepartmentId Id { get; }

    public Slug Slug { get; }

    public DepartmentId? ParentId { get; }

    public Name Name { get; }

    public Path Path { get; }

    public DateTime CreatedAt { get; }

    public DateTime? UpdatedAt { get; }

    public static Department Create(Slug slug, Name name, Path path, DepartmentId? parentId = null, DateTime? createdAt = null, DateTime? updatedAt = null)
    {
        return new Department(slug, name, path, parentId, createdAt, updatedAt);
    }
}