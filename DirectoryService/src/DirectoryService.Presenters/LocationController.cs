namespace DirectoryService.Presenters;

using DirectoryService.Contracts;
using DirectoryService.Domain;
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

        var name = Name.Create(request.Name, Location.MIN_NAME_LENGTH, Location.MAX_NAME_LENGTH);
        if (name.IsFailure)
        {
            return this.BadRequest(name.Error);
        }

        var timezone = Timezone.Create(request.Timezone);
        if (timezone.IsFailure)
        {
            return this.BadRequest(timezone.Error);
        }

        var address = Address.Create(string.Empty, string.Empty, string.Empty, string.Empty);

        var location = Location.Create(locationId, name.Value, address.Value, timezone.Value);

        return this.Ok("Location created");
    }
}
