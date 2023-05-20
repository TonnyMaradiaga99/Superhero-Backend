using Microsoft.EntityFrameworkCore;
using Superhero.Models;

namespace Superhero;

public class SuperheroContext: DbContext
{
    public  DbSet<superhero1> superhero1 {get; set;}

    public DbSet<attribute> attribute {get; set;}

    public DbSet<hero_attribute> hero_attribute {get; set;}

    public DbSet<hero_power> hero_power {get; set;}

    public DbSet<superpower> superpower {get; set;}

    public DbSet<race> race {get; set;}

    public DbSet<publisher> publisher {get; set;}

    public DbSet<gender> gender {get; set;}

    public DbSet<alignment> alignment {get; set;}

    public DbSet<colour> colour {get; set;}

    public SuperheroContext(DbContextOptions<SuperheroContext> options) : base(options){}
}
