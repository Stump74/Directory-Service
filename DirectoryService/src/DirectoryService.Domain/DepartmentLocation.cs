namespace DirectoryService.Domain;

using DirectoryService.Domain.ValueObjects;

public class DepartmentLocation
{
    public DepartmentLocationId Id { get; } = DepartmentLocationId.NewDepartmentLocationId();

    public required DepartmentId DepartmentId { get; set; }

    public required LocationId LocationId { get; set; }
}
