using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class colourServices : IcolourService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public colourServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(colour newcolour)
    {
        newcolour.colour_id = Guid.NewGuid();
        await context.AddAsync<colour>(newcolour);
        await context.SaveChangesAsync();
    }

    public IEnumerable<colour> Get()
    {
        return context.colour;
    }   

    public async Task Update(Guid id, colour updcolour)
    {
        var colour = context.colour.Find(id);
        if(colour != null)
        {
            colour.colour_id = updcolour.colour_id;
            context.Update(colour);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var colour = context.colour.Find(id);
        if (colour != null)
        {
            context.Remove(colour);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface IcolourService
{
    Task CreateAsync(colour newcolour);
    IEnumerable<colour> Get();
    Task Update(Guid id, colour updcolour);
    Task Delete(Guid id);
}
