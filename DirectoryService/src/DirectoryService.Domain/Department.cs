namespace DirectoryService.Domain;

using System;
using System.Collections.Generic;
using CSharpFunctionalExtensions;
using DirectoryService.Domain.ValueObjects;

public sealed class Department
{
    public const int MAX_NAME_LENGTH = 150;

    public const int MIN_NAME_LENGTH = 3;

    private readonly List<DepartmentLocation> _departmentLocations = [];

    private readonly List<DepartmentPosition> _departmentPositions = [];

    private readonly List<Department> _children = [];

    private Department(DepartmentId id, Name name, Identifier identifier)
    {
        Id = id;
        Name = name;
        Identifier = identifier;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = CreatedAt;
    }

    public IReadOnlyList<DepartmentLocation> Locations => _departmentLocations;

    public IReadOnlyList<DepartmentPosition> Positions => _departmentPositions;

    public DepartmentId Id { get; }

    public Guid? ParentId { get; private set; }

    public IReadOnlyList<Department> Children => _children;

    public Name Name { get; private set; }

    public Identifier Identifier { get; private set; }

    public Path? Path { get; private set; }

    public short Depth { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime UpdatedAt { get; private set; }

    public Deleted? DeletedAt { get; private set; }

    public static Result<Department> Create(DepartmentId id, Name name, Identifier identifier)
    {
        return new Department(id, name, identifier);
    }
}
