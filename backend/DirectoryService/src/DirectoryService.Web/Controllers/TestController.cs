using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace DirectoryService.Web.Controllers;

[ApiController]
[Route("api/[controller]")]
[SuppressMessage("Maintainability", "CA1515", Justification = "Controllers must be public")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() =>
        Ok(new { message = "TestController works!", timestamp = DateTimeOffset.UtcNow }); 
    
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id) =>
        Ok(new { id, message = $"Item {id} found!" });
}