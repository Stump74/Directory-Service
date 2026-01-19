namespace DirectoryService.Contracts;

public record UpdateUnitDto(string Name, string Description, Guid ParentId, IEnumerable<Guid> ChildId, IEnumerable<Guid> LocationId, IEnumerable<Guid> PositionId);
