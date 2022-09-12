using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers;

[Route("lec/demoone")]
public class Demo1Controller : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return Content("A plain GET request.");
    }

    [HttpGet("{id}")]
    public IActionResult InfoWithId(string id)
    {
        return Content($"A GET request with parameter id {id}");
    }

    [HttpGet("intdata/{id:int}")]
    public IActionResult InfoWithIntId(int id)
    {
        return Content($"A GET request with 3 segments and int id parameter: {id}");
    }
}
