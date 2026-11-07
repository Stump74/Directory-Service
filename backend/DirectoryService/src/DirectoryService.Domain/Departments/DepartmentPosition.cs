using DirectoryService.Domain.Positions;

namespace DirectoryService.Domain.Departments;

public class DepartmentPosition
{
    public required Guid Id { get; init; }
    public required DepartmentId DepartmentId { get; init; }
    public required PositionId PositionId { get; init; }
}