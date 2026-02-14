namespace DirectoryService.Domain.ValueObjects;

using System;

public record DepartmentPositionId
{
    private DepartmentPositionId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static DepartmentPositionId NewDepartmentPositionId() => new(Guid.NewGuid());
}
