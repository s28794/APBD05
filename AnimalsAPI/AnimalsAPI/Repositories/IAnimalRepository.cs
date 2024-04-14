using AnimalsAPI.Models;
namespace AnimalsAPI.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimals();
    Animal GetAnimal(int animalId);
    int CreateAnimal(Animal animal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int animalId);
} 