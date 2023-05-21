using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class superpower1Services : Isuperpower1Service

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public superpower1Services(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(superhero1 newsuperpower1)
    {
        newsuperpower1.Id_h = Guid.NewGuid();
        await context.AddAsync<superhero1>(newsuperpower1);
        await context.SaveChangesAsync();
    }

    public IEnumerable<superhero1> Get()
    {
        return context.superhero1;
    }   

    public async Task Update(Guid id, superhero1 updsuperhero1)
    {
        var superhero1 = context.superhero1.Find(id);
        if(superhero1 != null)
        {
            superhero1.Id_h = updsuperhero1.Id_h;
            context.Update(superhero1);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var superhero1 = context.superhero1.Find(id);
        if (superhero1 != null)
        {
            context.Remove(superhero1);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface Isuperpower1Service
{
    Task CreateAsync(superhero1 newsuperpower1);
    IEnumerable<superhero1> Get();
    Task Update(Guid id, superhero1 updsuperpower1);
    Task Delete(Guid id);
}