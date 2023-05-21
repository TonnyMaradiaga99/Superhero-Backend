using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class hero_powerServices : Ihero_powerService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public hero_powerServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(hero_power newheropower)
    {
        newheropower.power_id = Guid.NewGuid();
        await context.AddAsync<hero_power>(newheropower);
        await context.SaveChangesAsync();
    }

    public IEnumerable<hero_power> Get()
    {
        return context.hero_power;
    }   

    public async Task Update(Guid id, hero_power updheropower)
    {
        var hero_power = context.hero_power.Find(id);
        if(hero_power != null)
        {
            hero_power.power_id = updheropower.power_id;
            context.Update(hero_power);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var hero_power = context.hero_power.Find(id);
        if (hero_power != null)
        {
            context.Remove(hero_power);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface Ihero_powerService
{
    Task CreateAsync(hero_power newheropower);
    IEnumerable<hero_power> Get();
    Task Update(Guid id, hero_power updheropower);
    Task Delete(Guid id);
}