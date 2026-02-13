namespace DirectoryService.Presenters;

using DirectoryService.Contracts;
using DirectoryService.Domain;
using DirectoryService.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class DepartmentController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody]CreateDepartmentDto? request,
        CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return this.BadRequest("Request body is required.");
        }

        var departmentId = DepartmentId.NewUnitId();

        var title = Name.Create(request.Name, Department.MIN_NAME_LENGTH, Department.MAX_NAME_LENGTH);
        if (title.IsFailure)
        {
            return this.BadRequest(title.Error);
        }

        var identifier = Identifier.Create(request.Identifier);
        if (identifier.IsFailure)
        {
            return this.BadRequest(identifier.Error);
        }

        var department = Department.Create(departmentId, title.Value, identifier.Value);

        return this.Ok("Department created");
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery]GetUnitDto request,
        CancellationToken cancellationToken)
    {
        return this.Ok("Unit get");
    }

    [HttpGet("{unitId:guid}")]
    public async Task<IActionResult> GetById(
        [FromRoute]Guid unitId,
        CancellationToken cancellationToken)
    {
        return this.Ok("Unit get by id");
    }

    [HttpPut("{unitId:guid}")]
    public async Task<IActionResult> Update(
        [FromRoute]Guid unitId,
        [FromBody]UpdateUnitDto request,
        CancellationToken cancellationToken)
    {
        return this.Ok("Unit updated");
    }

    [HttpDelete("{unitId:guid}")]
    public async Task<IActionResult> Delete(
        [FromRoute]Guid unitId,
        CancellationToken cancellationToken)
    {
        return this.Ok("Unit deleted");
    }
}
