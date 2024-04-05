using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerAutoPublish.Controllers;
[ApiController]
[Route("[controller]/api")]
public class HomeController : Controller
{
    // GET: HomeController
    private readonly IConfiguration _configuration;

    public HomeController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet("GetAppSettingsValues")]
    public IActionResult GetAppSettingsValues()
    {
        // Example: Read a configuration value
        var mySetting = _configuration.GetConnectionString("DefaultConnection");
        var mySetting2 = _configuration.GetValue<string>( "CustomParams");

        // Use the configuration value in your logic
        return Ok($"The value of MySetting isssssssssss: {mySetting}");
    }

    [HttpGet("GetAppSettingsValuesAndInner")]
    public IActionResult GetAppSettingsValuesAndInner()
    {
        // Example: Read a configuration value
        var mySetting = _configuration["ConnectionStrings"];

        // Use the configuration value in your logic
        return Ok($"The value of MySetting is: {mySetting}");
    }
}
