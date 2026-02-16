namespace DirectoryService.Domain.ValueObjects;

using System;

public record PositionId
{
    private PositionId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static PositionId NewPositionId() => new(Guid.NewGuid());

    public static PositionId Empty() => new(Guid.Empty);
}
