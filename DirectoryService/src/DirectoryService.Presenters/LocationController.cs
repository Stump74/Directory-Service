namespace DirectoryService.Presenters;

using DirectoryService.Contracts;
using DirectoryService.Domain.ValueObjects;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class LocationController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateLocationDto? request,
        CancellationToken cancellationToken)
    {
        if (request == null)
        {
            return this.BadRequest("Request body is required.");
        }

        var locationId = LocationId.NewLocationId();

        var title = Title.Create(request.Title);
        if (title.IsFailure)
        {
            return this.BadRequest(title.Error);
        }

        var description = Description.Create(request.Description);
        if (description.IsFailure)
        {
            return this.BadRequest(description.Error);
        }

        var address = Address.Create(string.Empty, string.Empty, string.Empty, string.Empty);

        var location = Domain.Location.Create(locationId, title.Value, description.Value, address);

        return this.Ok("Location created");
    }
}
