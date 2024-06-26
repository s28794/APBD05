﻿using AnimalsAPI.Models;

namespace AnimalsAPI.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private static List<Animal> _animals;

    public AnimalRepository()
    {
        _animals = new List<Animal>();
    }
    
    public IEnumerable<Animal> GetAnimals()
    {
        return _animals;
    }

    public Animal GetAnimal(int animalId)
    {
        foreach (var animal in _animals)
        {
            if (animalId == animal.IdAnimal)
            {
                return animal;
            }
        }

        return null;
    }

    public int AddAnimal(Animal animal)
    {
        (int id, string name, Category category, double weight, string color) = animal;
        Animal newAnimal = new(id, name, category, weight, color);
        _animals.Add(newAnimal);
        return 1;
    }

    public int UpdateAnimal(Animal animal)
    {
        foreach (var animalInRep in _animals)
        {
            if (animalInRep.IdAnimal == animal.IdAnimal)
            {
                animalInRep.Name = animal.Name;
                animalInRep.Category = animal.Category;
                animalInRep.Mass = animal.Mass;
                animalInRep.FurColor = animal.FurColor;
                return 1;
            }
        }
        return 0;
    }

    public int DeleteAnimal(int animalId)
    {
        foreach (var animal in _animals)
        {
            if (animal.IdAnimal == animalId)
            {
                _animals.Remove(animal);
                return 1;
            }
        }
        
        return 0;
    }
}