using Microsoft.AspNetCore.Mvc;
using zad5.Database;
using zad5.Models;

namespace zad5.Controllers;

[ApiController]
[Route("/visit-controller")]

public class VisitController : ControllerBase
{
    [HttpGet]
    [Route("/visit-controller/{id:int}")]

    public IActionResult GetVisitByAnimalId(int id)
    {
        var visitDB = Data.VisitsDB;
        var listaWizyt = new List<Visit>();
        foreach (var wizyta in visitDB)
        {
            if (id == wizyta.zwierze.Id)
            {
                listaWizyt.Add(wizyta);
            }
        }

        if (listaWizyt.Count > 0)
        {
            return Ok(listaWizyt);
        }
        return NotFound();

    }

    [HttpPost]
    [Route("/visit-controller/{id:int}/{dataWizty}/{opisWizyty}/{Cena}")]
    public IActionResult addVisit(int id, String dataWizty,String opisWizyty,int cena)
    {
        var animalDB = Data.AnimalsDB;
        var visitDB = Data.VisitsDB;
        Animal szukane = null;
        foreach (var zwierze in animalDB)
        {
            if (zwierze.Id == id)
                szukane = zwierze;
        }

        if (szukane==null)
        {
            return NotFound();
        }

        Visit nowaWizyta = new Visit(dataWizty, szukane, opisWizyty, cena);
        visitDB.Add(nowaWizyta);
        return Ok();    
    }
}