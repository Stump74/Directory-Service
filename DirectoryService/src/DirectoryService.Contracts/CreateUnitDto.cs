namespace DirectoryService.Contracts;

public record CreateUnitDto(string Name, string Description, Guid ParentId, IEnumerable<Guid> ChildId, IEnumerable<Guid> LocationId, IEnumerable<Guid> PositionId);
