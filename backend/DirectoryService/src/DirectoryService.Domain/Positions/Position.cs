using CSharpFunctionalExtensions;
using DirectoryService.Domain.Errors;
using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Positions;

public sealed class Position
{
    private Position(Name name, DateTime? createdAt, DateTime? updatedAt)
    {
        Id = PositionId.New(id: null);
        Name = name;
        CreatedAt = createdAt ?? DateTime.UtcNow;
        UpdatedAt = updatedAt ?? DateTime.UtcNow;
    }
    // For EF Core
    private Position()
    {
        Id = null!;
        Name = null!;
    }
    public PositionId Id { get; }

    public Name Name { get; }

    public DateTime CreatedAt { get; }

    public DateTime? UpdatedAt { get; }

    public static Result<Position, Error> Create(Name name, DateTime? createdAt = null, DateTime? updatedAt = null)
    {
        return new Position(name, createdAt, updatedAt);
    }
}