using AnimalsAPI.Models;

namespace AnimalsAPI.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimal(int animalId);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int animalId);
}