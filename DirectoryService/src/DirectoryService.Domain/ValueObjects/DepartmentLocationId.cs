namespace DirectoryService.Domain.ValueObjects;

using System;

public record DepartmentLocationId
{
    private DepartmentLocationId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static DepartmentLocationId NewDepartmentLocationId() => new(Guid.NewGuid());
}
