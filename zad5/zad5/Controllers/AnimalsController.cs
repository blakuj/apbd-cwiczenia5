using Microsoft.AspNetCore.Mvc;

namespace zad5.Controllers;

[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }

}