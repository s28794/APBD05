using AnimalsAPI.Exceptions;
using AnimalsAPI.Models;
using AnimalsAPI.Repositories;

namespace AnimalsAPI.Services;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _animalRepository;

    public AnimalService(IAnimalRepository animalRepository)
    {
        _animalRepository = animalRepository;
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return _animalRepository.GetAnimals();
    }

    public Animal? GetAnimal(int animalId)
    {
        return _animalRepository.GetAnimal(animalId);
    }

    public int AddAnimal(Animal animal)
    {
        var enumerable = _animalRepository.GetAnimals();

        foreach (var x in enumerable)
        {
            if (x.IdAnimal == animal.IdAnimal)
            {
                throw new NotUniqueIdException();
            }
        }

        return _animalRepository.AddAnimal(animal);
    }

    public int UpdateAnimal(Animal animal)
    {
        return _animalRepository.UpdateAnimal(animal);
    }

    public int DeleteAnimal(int animalId)
    {
        return _animalRepository.DeleteAnimal(animalId);
    }
}