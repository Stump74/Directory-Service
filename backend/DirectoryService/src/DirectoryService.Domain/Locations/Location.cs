using DirectoryService.Domain.Shared;

namespace DirectoryService.Domain.Locations;

public sealed class Location
{
    private Location(Name name, Address address, Guid? id, DateTime? createdAt, DateTime? updatedAt)
    {
        Id = id ?? Guid.CreateVersion7();
        Name = name;
        Address = address;
        CreatedAt = createdAt ?? DateTime.UtcNow;
        UpdatedAt = updatedAt ?? DateTime.UtcNow;
    }
    public Guid Id { get; }

    public Name Name { get; }

    public Address Address { get; }

    public DateTime CreatedAt { get; }

    public DateTime? UpdatedAt { get; }

    public static Location Create(Name name, Address address, Guid? id = null, DateTime? createdAt = null, DateTime? updatedAt = null)
    {
        return new Location(name, address, id, createdAt, updatedAt);
    }
}
