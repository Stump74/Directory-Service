using CSharpFunctionalExtensions;
using DirectoryService.Domain.Errors;
using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Positions;

public sealed class Position
{
    private Position(Name name, Guid? id, DateTime? createdAt, DateTime? updatedAt)
    {
        Id = id ?? Guid.CreateVersion7();
        Name = name;
        CreatedAt = createdAt ?? DateTime.UtcNow;
        UpdatedAt = updatedAt ?? DateTime.UtcNow;
    }
    // For EF Core
    private Position()
    {
        Name = null!;
    }
    public Guid Id { get; }

    public Name Name { get; }

    public DateTime CreatedAt { get; }

    public DateTime? UpdatedAt { get; }

    public static Result<Position, Error> Create(Name name, Guid? id = null, DateTime? createdAt = null, DateTime? updatedAt = null)
    {
        return new Position(name, id, createdAt, updatedAt);
    }
}