namespace AnimalsAPI.Models;

public enum Category
{
    CAT, DOG, HAMSTER, BIRD, OTHER
}

public class Animal
{
    public int IdAnimal { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public double Mass { get; set; }
    public string FurColor { get; set; }
}