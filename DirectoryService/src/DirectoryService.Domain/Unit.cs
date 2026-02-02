namespace DirectoryService.Domain;

using DirectoryService.Domain.ValueObjects;

public class Unit
{
    private readonly List<UnitLocation> _unitLocations = [];

    private readonly List<UnitPosition> _unitPositions = [];

    private Unit(UnitId id)
    {
        Id = id;
    }

    public IReadOnlyList<UnitLocation> Locations => _unitLocations;

    public IReadOnlyList<UnitPosition> Positions => _unitPositions;

    private UnitId Id { get; set; }

    private Unit? Parent { get; set; }

    private List<Unit> Children { get; init; } = [];

    private string? Title { get; set; }

    private string? Description { get; set; }
}
