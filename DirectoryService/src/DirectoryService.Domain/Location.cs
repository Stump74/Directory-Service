namespace DirectoryService.Domain;

using CSharpFunctionalExtensions;
using DirectoryService.Domain.ValueObjects;

public sealed class Location
{
    private readonly List<DepartmentLocation> _departmentLocations = [];

    private Location(LocationId id, Title title, Description description, Address address)
    {
        Id = id;
        Title = title;
        Description = description;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = CreatedAt;
        Address = address;
    }

    public IReadOnlyList<DepartmentLocation> Units => _departmentLocations;

    public LocationId Id { get; private set; }

    public Title Title { get; private set; }

    public Description Description { get; private set; }

    public Address Address { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime UpdatedAt { get; private set; }

    public Deleted? DeletedAt { get; private set; }

    public static Result<Location> Create(LocationId id, Title title, Description description, Address address)
    {
        return new Location(id, title, description, address);
    }
}
