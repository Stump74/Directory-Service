namespace DirectoryService.Domain;

using DirectoryService.Domain.ValueObjects;

public class Location
{
    private Location(LocationId id)
    {
        Id = id;
    }

    public LocationId Id { get; private set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    private IReadOnlyList<UnitLocation> Units { get; set; } = [];
}
