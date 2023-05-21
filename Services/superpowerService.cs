using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class superpowerServices : IsuperpowerService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public superpowerServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(superpower newsuperpower)
    {
        newsuperpower.power_id = Guid.NewGuid();
        await context.AddAsync<superpower>(newsuperpower);
        await context.SaveChangesAsync();
    }

    public IEnumerable<superpower> Get()
    {
        return context.superpower;
    }   

    public async Task Update(Guid id, superpower updsuperpower)
    {
        var superpower = context.superpower.Find(id);
        if(superpower != null)
        {
            superpower.power_id = updsuperpower.power_id;
            context.Update(superpower);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var superpower = context.superpower.Find(id);
        if (superpower != null)
        {
            context.Remove(superpower);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface IsuperpowerService
{
    Task CreateAsync(superpower newsuperpower);
    IEnumerable<superpower> Get();
    Task Update(Guid id, superpower updsuperpower);
    Task Delete(Guid id);
}