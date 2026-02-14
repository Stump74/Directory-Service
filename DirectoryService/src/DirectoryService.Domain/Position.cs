namespace DirectoryService.Domain;

using System;
using System.Collections.Generic;
using CSharpFunctionalExtensions;
using DirectoryService.Domain.ValueObjects;

public sealed class Position
{
    public const int MAX_NAME_LENGTH = 100;

    public const int MIN_NAME_LENGTH = 3;

    private readonly List<DepartmentPosition> _departmentPosition = [];

    private Position(PositionId id, Name name, Description description)
    {
        Id = id;
        Name = name;
        Description = description;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = CreatedAt;
    }

    public IReadOnlyList<DepartmentPosition> Units => _departmentPosition;

    public PositionId Id { get; }

    public Name Name { get; private set; }

    public Description Description { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime UpdatedAt { get; private set; }

    public Deleted? DeletedAt { get; private set; }

    public static Result<Position> Create(PositionId id, Name name, Description description)
    {
        return new Position(id, name, description);
    }
}
