namespace DirectoryService.Domain;

using System;
using System.Collections.Generic;
using CSharpFunctionalExtensions;
using DirectoryService.Domain.ValueObjects;

public sealed class Location
{
    public const int MAX_NAME_LENGTH = 120;

    public const int MIN_NAME_LENGTH = 3;

    private readonly List<DepartmentLocation> _departmentLocations = [];

    private Location(LocationId id, Name name, Address address, Timezone timezone)
    {
        Id = id;
        Name = name;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = CreatedAt;
        Address = address;
        Timezone = timezone;
    }

    public IReadOnlyList<DepartmentLocation> Units => _departmentLocations;

    public LocationId Id { get; private set; }

    public Name Name { get; private set; }

    public Address Address { get; private set; }

    public Timezone Timezone { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime UpdatedAt { get; private set; }

    public Deleted? DeletedAt { get; private set; }

    public static Result<Location> Create(LocationId id, Name name, Address address, Timezone timezone)
    {
        return new Location(id, name, address, timezone);
    }
}
