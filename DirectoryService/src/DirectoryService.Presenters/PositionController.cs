namespace DirectoryService.Presenters;

using DirectoryService.Contracts;
using DirectoryService.Domain;
using DirectoryService.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PositionController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreatePositionDto? request,
        CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return this.BadRequest("Request body is required.");
        }

        var positionId = PositionId.NewPositionId();

        var title = Name.Create(request.Name, Position.MIN_NAME_LENGTH, Position.MAX_NAME_LENGTH);
        if (title.IsFailure)
        {
            return this.BadRequest(title.Error);
        }

        var description = Description.Create(request.Description);
        if (description.IsFailure)
        {
            return this.BadRequest(description.Error);
        }

        var position = Position.Create(positionId, title.Value, description.Value);

        return this.Ok("Position created");
    }
}
