using System.ComponentModel.DataAnnotations.Schema;

namespace Farm.Models;

public class Animal
{
    public int Id {get; set;}
    
    public required string Name {get; set;}

    public int SpeciesId {get; set;}

    [ForeignKey ("SpeciesId")]
    public Species Species {get; set;} = null!;
}