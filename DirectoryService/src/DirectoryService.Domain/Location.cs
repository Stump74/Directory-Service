namespace DirectoryService.Domain;

using DirectoryService.Domain.ValueObjects;

public class Location
{
    private readonly List<UnitLocation> _unitLocations = [];

    private Location(LocationId id)
    {
        Id = id;
    }

    public IReadOnlyList<UnitLocation> Units => _unitLocations;

    private LocationId Id { get; set; }

    private string? Title { get; set; }

    private string Description { get; set; } = string.Empty;
}
