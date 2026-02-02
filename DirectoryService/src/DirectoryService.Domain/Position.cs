namespace DirectoryService.Domain;

using DirectoryService.Domain.ValueObjects;

public class Position
{
    private readonly List<UnitPosition> _unitPositions = [];

    private Position(PositionId id, Address address)
    {
        Id = id;
        Address = address;
    }

    public IReadOnlyList<UnitPosition> Units => _unitPositions;

    private PositionId Id { get; }

    private string? Title { get; set; }

    private string Description { get; set; } = string.Empty;

    private Address Address { get; set; }
}
