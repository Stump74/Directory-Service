using DirectoryService.Domain.Locations;

namespace DirectoryService.Domain.Departments;

public sealed class DepartmentLocation
{
    public required Guid Id { get; init; }
    public required DepartmentId DepartmentId { get; init; }
    public required LocationId LocationId { get; init; }
    public bool IsPrimary { get; init; }
}