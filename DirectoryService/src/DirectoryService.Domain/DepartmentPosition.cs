namespace DirectoryService.Domain;

using System;
using DirectoryService.Domain.ValueObjects;

public class DepartmentPosition
{
    public DepartmentPositionId Id { get; } = DepartmentPositionId.NewDepartmentPositionId();

    public required DepartmentId DepartmentId { get; set; }

    public required PositionId PositionId { get; set; }
}
