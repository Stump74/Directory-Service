namespace DirectoryService.Contracts;

public record UpdateDepartmentDto(string Name, string Description, Guid ParentId, IEnumerable<Guid> ChildId, IEnumerable<Guid> LocationId, IEnumerable<Guid> PositionId);
