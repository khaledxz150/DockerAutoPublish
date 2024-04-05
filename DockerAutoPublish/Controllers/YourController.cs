using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
namespace DockerAutoPublish.Controllers;
[ApiController]
[Route("[controller]")]
public class YourController : ControllerBase
{
    private readonly AppSettings _config;

    public YourController( IOptions<AppSettings> options)
    {
        _config = options.Value;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { _config, Assemply  = typeof(AppSettings).Assembly.FullName});
    }

    [HttpPost("update")]
    public IActionResult UpdateSettings([FromBody] AppSettings newSettings)
    {
        // Apply new settings

        return Ok();
    }
}













