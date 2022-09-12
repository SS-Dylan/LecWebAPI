using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers;

[Route("[controller]/[action]")]
public class Demo2Controller : Controller
{
    public IActionResult Index()
    {
        return Content("Another simple GET request");
    }

    [HttpGet("{id}")]
    public IActionResult Details(string id)
    {
        return Content($"Details of {id}");
    }
}
