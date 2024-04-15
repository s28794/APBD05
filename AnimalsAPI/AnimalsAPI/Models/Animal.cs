namespace AnimalsAPI.Models;

public enum Category
{
    Cat = 0, Dog = 1, Hamster = 2, Bird = 3, Other = 4
}

public class Animal
{

    public int IdAnimal { get; set; }
    public string Name { get; set; }
    public Category Category { get; set; }
    public double Mass { get; set; }
    public string FurColor { get; set; }

    public Animal(int idAnimal, string name, Category category, double mass, string furColor)
    {
        IdAnimal = idAnimal;
        Name = name;
        Category = category;
        Mass = mass;
        FurColor = furColor;
    }

        public void Deconstruct(out int idAnimal, out string name, out Category category, out double mass, out string furColor)
    {
        idAnimal = IdAnimal;
        name = Name;
        category = Category;
        mass = Mass;
        furColor = FurColor;
    }
}