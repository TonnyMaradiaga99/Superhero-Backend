using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class raceServices : IraceService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public raceServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(race newrace)
    {
        newrace.race_id = Guid.NewGuid();
        await context.AddAsync<race>(newrace);
        await context.SaveChangesAsync();
    }

    public IEnumerable<race> Get()
    {
        return context.race;
    }   

    public async Task Update(Guid id, race updrace)
    {
        var race = context.race.Find(id);
        if(race != null)
        {
            race.race_id = updrace.race_id;
            context.Update(race);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var race = context.race.Find(id);
        if (race != null)
        {
            context.Remove(race);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface IraceService
{
    Task CreateAsync(race newrace);
    IEnumerable<race> Get();
    Task Update(Guid id, race updrace);
    Task Delete(Guid id);
}