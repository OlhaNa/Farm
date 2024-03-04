namespace Farm.Models;

public class Species
{
    public int Id {get; set;}
    public required string Name {get; set;}
    public List<Animal> Animals  {get; set;} = [];
}