namespace DirectoryService.Domain;

using DirectoryService.Domain.ValueObjects;

public class Unit
{
    private Unit(UnitId id)
    {
        Id = id;
    }

    public UnitId Id { get; private set; }

    public Unit? Parent { get; set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    private List<Unit> Children { get; init; } = [];

    private IReadOnlyList<UnitLocation> Locations { get; init; } = [];

    private IReadOnlyList<UnitPosition> Positions { get; init; } = [];
}
