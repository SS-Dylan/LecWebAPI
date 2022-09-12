using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers;

[Route("lec/demoone")]
public class Demo1Controller : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}
