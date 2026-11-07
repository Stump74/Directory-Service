using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Locations;

public sealed class Location
{
    private Location(Name name, Address address, DateTime? createdAt, DateTime? updatedAt)
    {
        Id = LocationId.New(id: null);
        Name = name;
        Address = address;
        CreatedAt = createdAt ?? DateTime.UtcNow;
        UpdatedAt = updatedAt ?? DateTime.UtcNow;
    }
    // For EF Core
    private Location()
    {
        Id = null!;
        Name = null!;
        Address = null!;
    }
    public LocationId Id { get; }

    public Name Name { get; }

    public Address Address { get; }

    public DateTime CreatedAt { get; }

    public DateTime? UpdatedAt { get; }

    public static Location Create(Name name, Address address, DateTime? createdAt = null, DateTime? updatedAt = null)
    {
        return new Location(name, address, createdAt, updatedAt);
    }
}
