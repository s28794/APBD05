using System.Runtime.InteropServices.JavaScript;

namespace AnimalsAPI.Models;

public class Appointment
{
    public string VisitDate { get; set; }
    public Animal Animal { get; set; }
    public string Description { get; set; }
    public double price { get; set; }

    public Appointment(string visitDate, Animal animal, string description, double price)
    {
        VisitDate = visitDate;
        Animal = animal;
        Description = description;
        this.price = price;
    }

    public void Deconstruct(out string visit, out Animal animal, out string description, out double price)
    {
        visit = VisitDate;
        animal = Animal;
        description = Description;
        price = this.price;
    }
}