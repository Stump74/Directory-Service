namespace DirectoryService.Domain;

using DirectoryService.Domain.ValueObjects;

public class Position
{
    private Position(PositionId id, Address address)
    {
        Id = id;
        Address = address;
    }

    public PositionId Id { get; private set; }

    public required string Title { get; set; }

    public string Description { get; set; } = string.Empty;

    public Address Address { get; set; }

    private IReadOnlyList<UnitPosition> Units { get; set; } = [];
}
