using Farm.Models;
using Microsoft.EntityFrameworkCore;

namespace Farm;

public class Farm : DbContext
{
    public DbSet<Animal> Animals {get; set;} = null!;
    public DbSet<Species> Species {get; set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=farm; Username=farm; Password=farm;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var sheep = new Species
        {
            Id = -1,
            Name = "sheep",
        };

        var pig = new Species
        {
            Id = -2,
            Name = "pig",
        };

        modelBuilder.Entity<Species>().HasData(sheep);
        modelBuilder.Entity<Species>().HasData(pig);

        var shaun = new Animal
        {
            Id = -1,
            Name = "Shaun",
            SpeciesId = -1,
        };

        var timmy = new Animal
        {
            Id = -2,
            Name = "Timmy",
            SpeciesId = -1,
        };

        var peppa = new Animal
        {
            Id = -3,
            Name = "Peppa",
            SpeciesId = -2,
        };

        modelBuilder.Entity<Animal>().HasData(shaun);
        modelBuilder.Entity<Animal>().HasData(timmy);
        modelBuilder.Entity<Animal>().HasData(peppa);
    }
}

