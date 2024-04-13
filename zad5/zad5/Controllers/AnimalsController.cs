using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using zad5.Database;
using zad5.Models;

namespace zad5.Controllers;

[ApiController]
[Route("/animals-controller")]
//[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    
    [HttpGet]
    [Route("/animals-controller")]
    public IActionResult GetAnimals()
    {
        var data = Data.AnimalsDB;
        return Ok(data);
    }
    
    [HttpGet]
    [Route("/animals-controller/{id:int}")]
    public IActionResult GetAnimalsByID(int id)
    {
        var data = Data.AnimalsDB;
        foreach (var zwierze in data)
        {
            if (zwierze.Id == id)
            {
                return Ok(zwierze);
            }
        }

        return NotFound();

    }
    [HttpPost]
    [Route("api/animals/{id:int}/{firstName}/{kategoria}/{masa:float}/{siersc}")]
    public IActionResult AddAnimals(int id, String firstName, String kategoria,float masa,String siersc)
    {
        var data = Data.AnimalsDB;
        foreach (var zwierze in data)
        {
            if (zwierze.Id == id)
            {
                return NotFound();
            }
        }

        Animal animal = new Animal(id, firstName, kategoria, masa, siersc);
        data.Add(animal);
        return Created();
    }
    [HttpPut]
    [Route("api/animals/{id:int}/{firstName}/{kategoria}/{masa:float}/{siersc}")]
    public IActionResult EditAnimals(int id, String firstName, String kategoria,float masa,String siersc)
    {
        var data = Data.AnimalsDB;
        foreach (var zwierze in data)
        {
            if (zwierze.Id == id)
            {
                zwierze.Name = firstName;
                zwierze.Category = kategoria;
                zwierze.Mass = masa;
                zwierze.Colour = siersc;
                
                return Ok();
            }
        }

        return NotFound();

    }

    [HttpDelete]
    [Route("api/animals/{id:int}")]
    public IActionResult DeleteAnimals(int id)
    {
        var data = Data.AnimalsDB;
        foreach (var zwierze in data)
        {
            if (zwierze.Id == id)
            {
                data.Remove(zwierze);
                return Ok();
            }
        }

        return NotFound();
    }
}