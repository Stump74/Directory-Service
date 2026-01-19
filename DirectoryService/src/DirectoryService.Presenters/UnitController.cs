namespace DirectoryService.Presenters;

using DirectoryService.Contracts;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UnitController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody]CreateUnitDto request,
        CancellationToken cancellationToken)
    {
        return this.Ok("Unit created");
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
