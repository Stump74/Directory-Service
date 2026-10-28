using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Departments;

public sealed class Department
{
    private Department( Slug slug, Name name, Path path, Guid? id, Guid? parentId, DateTime? createdAt, DateTime? updatedAt)
    {
        Id = id ?? Guid.CreateVersion7();
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
        Slug = null!;
        Name = null!;
        Path = null!;
    } 
    public Guid Id { get; }

    public Slug Slug { get; }

    public Guid? ParentId { get; }

    public Name Name { get; }

    public Path Path { get; }

    public DateTime CreatedAt { get; }

    public DateTime? UpdatedAt { get; }

    public static Department Create( Slug slug, Name name, Path path, Guid? id = null, Guid? parentId = null, DateTime? createdAt = null, DateTime? updatedAt = null)
    {
        return new Department(slug, name, path, id, parentId, createdAt, updatedAt);
    }
}