namespace DirectoryService.Domain.ValueObjects;

public record UnitId
{
    private UnitId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static UnitId NewUnitId() => new(Guid.NewGuid());

    public static UnitId Empty() => new(Guid.Empty);
}
