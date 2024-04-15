using AnimalsAPI.Models;
using AnimalsAPI.Services;
using AnimalsAPI.Exceptions;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AnimalsAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AnimalController : ControllerBase
{
    private IAnimalService _animalService;

    public AnimalController(IAnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = _animalService.GetAnimals();

        return Ok(animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalService.GetAnimal(id);
        if (animal == null)
        {
            return StatusCode(StatusCodes.Status404NotFound);
        }

        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        try
        {
            _animalService.CreateAnimal(animal);
            return StatusCode(StatusCodes.Status201Created);
        }
        catch (NotUniqueIdException e)
        {
            return StatusCode(StatusCodes.Status400BadRequest);
        }
        
    }
    
    [HttpPut]
    public IActionResult UpdateAnimal(Animal animal)
    {
        int status = _animalService.UpdateAnimal(animal);
        if (status == 1)
        {
            return Ok();
        }

        return StatusCode(StatusCodes.Status404NotFound);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        int status = _animalService.DeleteAnimal(id);
        if (status == 1)
        {
            return NoContent();
        }
        return StatusCode(StatusCodes.Status404NotFound);
    }
}