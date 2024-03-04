using Farm.Models;

namespace Farm;

public class Farmer 
{
    private readonly Farm _farm;
     
    public Farmer(Farm farm) 
    {
        _farm = farm;
    }

    public void AddAnimal() 
    {
        Console.Write("What is the name of the animal you wish to add? ");
        var animalName = Console.ReadLine() ?? "";
        Console.Write("What is the species of the animal you wish to add? ");
        var animalSpecies = Console.ReadLine() ?? "";
        var matchingSpecies = _farm.Species.SingleOrDefault(species => species.Name == animalSpecies.ToLower());
        if (matchingSpecies == null)
        {
            Console.WriteLine($"{animalSpecies} not in database yet, adding now...");
            matchingSpecies = _farm.Species.Add(new Species
            {
                Name = animalSpecies.ToLower(),
            }).Entity;
            _farm.SaveChanges();
            Console.WriteLine("Done!");
        }
        _farm.Animals.Add(new Animal
        {
            Name = animalName,
            SpeciesId = matchingSpecies.Id,
        }); 
        _farm.SaveChanges();
        Console.WriteLine($"{animalName} has been added to the database.");
    }
}